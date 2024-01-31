namespace BeneficialStrategies.Iso20022.Metadata;

public interface IDropdownDataSource<T>
    where T : IDropdownRow
{
    IEnumerable<T> DropdownValues { get; }
}
