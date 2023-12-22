using System.Reflection;

namespace BeneficialStrategies.Iso20022.Common.Metadata;

public class EnumMetadataItem : IEnumMetadataDropdownRow
{
    private Attribute[] _attributes;
    private MemberInfo _memberInfo;
 
    public EnumMetadataItem(MemberInfo memberInfo)
    {
        _attributes = memberInfo.GetCustomAttributes().ToArray();
        _memberInfo = memberInfo;
        IsoId = memberInfo.GetCustomAttribute<IsoIdAttribute>()?.Id ?? string.Empty;
        Description = memberInfo.GetCustomAttribute<DescriptionAttribute>()?.Description ?? memberInfo.Name;
    }

    public string Key => _memberInfo.Name;

    public string IsoId { get; }

    public string Description { get; }
}