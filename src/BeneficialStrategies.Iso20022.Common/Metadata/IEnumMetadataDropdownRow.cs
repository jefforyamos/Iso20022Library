namespace BeneficialStrategies.Iso20022.Metadata;

#if DECLARE_INTERNALSERIALIZATION

public interface IEnumMetadataDropdownRow<TEnum> : IDropdownRow
    where TEnum : struct
{
    TEnum Value { get; }

    string IsoId { get; }

}

#endif
