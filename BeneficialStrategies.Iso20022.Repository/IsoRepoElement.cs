using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Repository;

public abstract class IsoRepoElement
{
    protected readonly XElement xElement;

    public IsoRepoElement(XElement xElement)
    {
        this.xElement = xElement ?? throw new ArgumentNullException(nameof(xElement));
        this.Id = xElement?.Attribute(IsoXmlAttributes.Xmi.Id)?.Value ?? "Unknown";
        Name = xElement?.Attribute(IsoXmlAttributes.Default.Name)?.Value ?? "??";
        GenNames = new CSharpDerivedNames(this);
    }

    public string Id { get; }

    public string Name { get; }

    public CSharpDerivedNames GenNames { get; } 

    public override string ToString()
    {
        return $"{this.GetType().Name} {this.Name} {this.Id}";
    }
}

public class CSharpDerivedNames
{
    IsoRepoElement _parent;
    public CSharpDerivedNames(IsoRepoElement parent)
    {
        _parent = parent;
    }

    public string Enum => _parent.Name;

    public string DropdownSource => $"{_parent.Name}DropdownSource";

    public string IDropdownSource => $"I{_parent.Name}DropdownSource"; 

    public string IDropdownRow => $"I{_parent.Name}DropdownRow";

    public string DropdownRow => $"{_parent.Name}DropdownRow";
}
