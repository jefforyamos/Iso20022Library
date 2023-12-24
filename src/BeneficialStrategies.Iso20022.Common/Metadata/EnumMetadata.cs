
using System.Reflection;

namespace BeneficialStrategies.Iso20022.Common.Metadata;

/// <summary>
/// Provides implementation of <seealso cref="IDropdownDataSource{T}"/> by gathering information from metadata that adorns the code generated from the ISO20022 specification.
/// </summary>
/// <typeparam name="TEnum">The data type of the enumeration for this set of possible values.</typeparam>
/// <typeparam name="TRowInterface">The data type of the interface implemented by this </typeparam>
/// <typeparam name="TRowImpl">The data type that extends <seealso cref="EnumMetadataItem"/> providing the required properties appropriate for this type of information.</typeparam>
public abstract class EnumMetadataManager<TEnum,TRowInterface,TRowImpl> : IDropdownDataSource<TRowInterface>
    where TEnum : struct
    where TRowInterface : IEnumMetadataDropdownRow<TEnum>
    where TRowImpl : EnumMetadataItem<TEnum>, TRowInterface
{
    protected readonly Dictionary<TEnum, TRowImpl> _lookup;
    protected readonly TRowInterface[] _listAsLoaded;

    /// <summary>
    /// Called by the implementation class in its constructor.
    /// </summary>
    /// <param name="rowConversionFunction">Function that constructs and returns a <see cref="TRowImpl"/> instance.</param>
    protected EnumMetadataManager(Func<TEnum,MemberInfo,TRowImpl> rowConversionFunction)
    {
        var enumType = typeof(TEnum);
        var query = from enumValue in enumType.GetEnumValues().Cast<TEnum>()
                    let memberName = enumValue.ToString()
                    let memberInfo = enumType.GetMember(memberName).First()
                    let converted = rowConversionFunction.Invoke(enumValue, memberInfo)
                    select new { Key = enumValue, Info = memberInfo, RowData = converted };
        var preProcessed = query.ToArray();
        _lookup = preProcessed.ToDictionary(item => item.Key, item => item.RowData);
        _listAsLoaded = preProcessed.Select(i => i.RowData).ToArray();
    }

    /// <summary>
    /// Provides data to use in a dropdown list or in validation logic.
    /// </summary>
    // IEnumerable<TRowInterface> IDropdownDataSource<TRowInterface>.DropdownValues => _listAsLoaded;
    public IEnumerable<TRowInterface> DropdownValues => _listAsLoaded;

    /// <summary>
    /// Given a specific enum value, looks up the corresponding row data.
    /// </summary>
    /// <param name="itemValue"></param>
    /// <returns></returns>
    public TRowInterface Lookup(TEnum itemValue) => _lookup[itemValue];
}
