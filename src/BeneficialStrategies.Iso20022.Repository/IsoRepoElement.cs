using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Repository;

public abstract class IsoRepoElement
{
    protected internal readonly XElement xElement;

    public IsoRepoElement(XElement xElement)
    {
        this.xElement = xElement ?? throw new ArgumentNullException(nameof(xElement));
        this.Id = xElement?.Attribute(IsoXmlAttributes.Xmi.Id)?.Value ?? "Unknown";
        Name = xElement?.Attribute(IsoXmlAttributes.Default.Name)?.Value ?? "??";
        var definition = xElement?.Attribute(IsoXmlAttributes.Default.Definition)?.Value ?? string.Empty;
        Definition = definition.Split("\r\n");
        GenNames = new CSharpDerivedNames(this);
    }

    public string Id { get; }

    public string Name { get; }

    public string[] Definition { get; internal set; }

    /// <summary>
    /// For the definition embedded inside a desc attribute.
    /// </summary>
    public string DefinitionWithQuotesDoubled => string.Join(" ", Definition).Replace("\"", "\"\"");

    public CSharpDerivedNames GenNames { get; }

    /// <summary>
    /// The ISO20022 repo sometimes has descriptions in the derived parent and not in the derived definition.
    /// After parential hierarchy is established, this allows appropriate values to be updated from the parent.
    /// </summary>
    /// <param name="derivationParent">Element from which this item is derived.</param>
    internal void UpdateMissingElementValues(IsoRepoElement derivationParent)
    { 
        if (Definition.Length == 1 && string.IsNullOrWhiteSpace(Definition[0]))
        {
            Definition = derivationParent.Definition;
        }
    }

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
