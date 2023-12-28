using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

[assembly: InternalsVisibleToAttribute("BeneficialStrategies.Iso20022.Repository.UnitTest")]

namespace BeneficialStrategies.Iso20022.Repository;

public class IsoRepository : IsoRepoElement
{
    public IsoRepository(XDocument loadedDocument) : base(loadedDocument.Elements().First())
    {
        LoadedXDocument = loadedDocument;
        Version = xElement.Attribute(IsoXmlAttributes.Xmi.Version)?.Value ?? string.Empty;
        var childElements = xElement.Elements().ToArray();
        DataDictionary = new DataDictionary(childElements[0]);
    }
    public string Version { get; }

    public DataDictionary DataDictionary { get; }

    public XDocument LoadedXDocument { get; }

    public static IsoRepository Load(string fileName = CurrentlySupportedRepoFile)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        XDocument xDocument = XDocument.Load(fileName);

        Console.WriteLine($"Loaded {fileName} after {stopWatch.Elapsed.TotalSeconds} seconds. ");

        var repo = new IsoRepository(xDocument);
        stopWatch.Stop();
        Console.WriteLine($"Finished iterations after {stopWatch.Elapsed.TotalSeconds} seconds.");
        return repo;
    }
    public const string CurrentlySupportedRepoFile = "20230719_ISO20022_2013_eRepository.iso20022";
}
