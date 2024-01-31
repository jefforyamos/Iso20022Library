using System.Reflection;

namespace BeneficialStrategies.Iso20022.Metadata;

public class EnumMetadataItem<TEnum> : IEnumMetadataDropdownRow<TEnum>
    where TEnum : struct
{
    protected readonly MemberInfo _memberInfo;
    protected readonly Attribute[] _attributes;
 
    public EnumMetadataItem(TEnum value, MemberInfo memberInfo)
    {
        Value = value;
        _attributes = memberInfo.GetCustomAttributes().ToArray();
        _memberInfo = memberInfo;
        IsoId = memberInfo.GetCustomAttribute<IsoIdAttribute>()?.Id ?? string.Empty;
        Description = memberInfo.GetCustomAttribute<DescriptionAttribute>()?.Description ?? memberInfo.Name;
    }

    public TEnum Value { get; }

    public string Key => _memberInfo.Name;

    public string IsoId { get; }

    public string Description { get; }
}