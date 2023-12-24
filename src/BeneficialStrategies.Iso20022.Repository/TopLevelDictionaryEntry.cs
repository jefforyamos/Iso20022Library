using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Repository;

public abstract class TopLevelDictionaryEntry : IsoRepoElement
{
    public TopLevelDictionaryEntry(XElement xElement)
        : base(xElement)
    {
        Type = xElement?.Attribute(IsoXmlAttributes.Xsi.Type)?.Value ?? "??";
    }

    public string Type { get; }


    public override string ToString()
    {
        return $"{this.GetType().Name} {this.Type} {this.Name} {this.Id}";
    }
}
