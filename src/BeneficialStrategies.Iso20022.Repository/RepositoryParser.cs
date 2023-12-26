using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Repository;

public class RepositoryParser
{
    public const string CurrentlySupportedRepoFile = "20230719_ISO20022_2013_eRepository.iso20022";

    public IsoRepository Repository { get;}

    public RepositoryParser(string fileName = CurrentlySupportedRepoFile)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        XDocument xDocument = XDocument.Load(fileName);
        Console.WriteLine($"Loaded {fileName} after {stopWatch.Elapsed.TotalSeconds} seconds. ");
        var repo = xDocument.Elements().First();
        Repository = new IsoRepository(xDocument);
        stopWatch.Stop();
        Console.WriteLine($"Finished iterations after {stopWatch.Elapsed.TotalSeconds} seconds.");
    }
}
