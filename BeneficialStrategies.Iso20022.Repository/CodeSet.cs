using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Repository;

public class CodeSet : TopLevelDictionaryEntry
{
    public CodeSet(XElement xElement) : base(xElement)
    {
        Example = xElement.Element(IsoXmlElements.Default.Example)?.Value ?? string.Empty;
        Codes = xElement.Elements(IsoXmlElements.Default.Code)
            .Select(e => new Code(e))
            .Where(item => !string.IsNullOrWhiteSpace( item.CodeName))
            .ToArray();
    }

    public string Example { get; }

    public bool IsExternal => Codes.Length == 0;

    public Code[] Codes { get; }
}

