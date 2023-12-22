
namespace BeneficialStrategies.Iso20022.Common.Metadata;

public class EnumMetadataManager<TEnum> : IDropdownDataSource<IDropdownRow>
    where TEnum : struct
{
    private readonly Dictionary<TEnum, EnumMetadataItem> _lookup;
    private readonly EnumMetadataItem[] _listAsLoaded;

    public EnumMetadataManager()
    {
        var enumType = typeof(TEnum);
        var ordinalCounter = 0;
        var query = from enumValue in enumType.GetEnumValues().Cast<TEnum>()
                    let memberName = enumValue.ToString()
                    let memberInfo = enumType.GetMember(memberName).First()
                    let specifiedOrder = ordinalCounter++
                    select new { Key = enumValue, Info = memberInfo, Info2 = new EnumMetadataItem(memberInfo) };
        var preProcessed = query.ToArray();
        _lookup = preProcessed.ToDictionary(item => item.Key, item => item.Info2);
        _listAsLoaded = preProcessed.Select(i => i.Info2).ToArray();
    }

    public IEnumerable<IDropdownRow> DropdownValues => _listAsLoaded;

    public EnumMetadataItem Lookup(TEnum itemValue)
    {
        return _lookup[itemValue];
    }
}
