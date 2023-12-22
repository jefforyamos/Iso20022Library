using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Repository;

public abstract class TopLevelDictionaryEntry : IsoRepoElement
{
    public TopLevelDictionaryEntry(XElement xElement)
        : base(xElement)
    {
        Type = xElement?.Attribute(IsoXmlAttributes.Xsi.Type)?.Value ?? "??";
        Definition = xElement?.Attribute(IsoXmlAttributes.Default.Definition)?.Value ?? "??";
    }

    public string Type { get; }


    public string Definition { get; }

    /// <summary>
    /// For the definition embedded inside a desc attribute.
    /// </summary>
    public string DefinitionWithQuotesDoubled => Definition.Replace("\"", "\"\"");

    public override string ToString()
    {
        return $"{this.GetType().Name} {this.Type} {this.Name} {this.Id}";
    }
}
