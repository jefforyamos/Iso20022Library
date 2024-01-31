namespace BeneficialStrategies.Iso20022.Metadata;

public interface IEnumMetadataDropdownRow<TEnum> : IDropdownRow
    where TEnum : struct
{
    TEnum Value { get; }

    string IsoId { get; }

}
