namespace BeneficialStrategies.Iso20022.Metadata;

#if DECLARE_INTERNALSERIALIZATION

public interface IDropdownDataSource<T>
    where T : IDropdownRow
{
    IEnumerable<T> DropdownValues { get; }
}

#endif 
