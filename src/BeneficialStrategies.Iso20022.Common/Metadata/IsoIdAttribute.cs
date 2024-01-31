namespace BeneficialStrategies.Iso20022.Metadata;

public class IsoIdAttribute : Attribute
{
    public IsoIdAttribute(string id)
    {
        Id = id;
    }

    /// <summary>
    /// The official identifier assigned to this item by the ISO 20022 working group.
    /// </summary>
    public string Id { get; }
}

