namespace BeneficialStrategies.Iso20022.Common.Metadata;

public interface IDropdownDataSource<T>
    where T : IDropdownRow
{
    IEnumerable<T> DropdownValues { get; }
}
