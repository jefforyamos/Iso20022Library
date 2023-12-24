﻿

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if income is to be paid out (distributed) or retained (accumulated).
/// </summary>
[Serializable]
[IsoId("_awwx5dp-Ed-ak6NoX_4Aeg_-1525096597")]
[Description(@"Specifies if income is to be paid out (distributed) or retained (accumulated).")]
public enum DistributionPolicyCode
{


    /// <summary>
    /// Income is distributed to the investors in the fund.
    /// </summary>
    [IsoId("_awwx5tp-Ed-ak6NoX_4Aeg_1041617774")]
    [Description(@"Income is distributed to the investors in the fund.")]
    DIST,


    /// <summary>
    /// Income is added to the capital of the fund.
    /// </summary>
    [IsoId("_aw6i4Np-Ed-ak6NoX_4Aeg_1041617805")]
    [Description(@"Income is added to the capital of the fund.")]
    ACCU,

}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DistributionPolicyCodeMetadataExtensions
{
    private static readonly DistributionPolicyCodeDropdownSource _dropdownSource = new DistributionPolicyCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDistributionPolicyCodeDropdownRow GetMetadata(this DistributionPolicyCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



/// <summary>
/// The values that should be expected from a single row of dropdown data.
/// </summary>
public partial interface IDistributionPolicyCodeDropdownRow : IEnumMetadataDropdownRow<DistributionPolicyCode>
{
}


/// <summary>
/// Default implementation of <seealso cref="IDistributionPolicyCodeDropdownRow"/> that contains metadata embedded in the code.
/// </summary>
public partial class DistributionPolicyCodeDropdownRow : EnumMetadataItem<DistributionPolicyCode>, IDistributionPolicyCodeDropdownRow
{
    /// <summary>
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DistributionPolicyCodeDropdownRow(DistributionPolicyCode value, MemberInfo memberInfo) : base( value, memberInfo)
    {
    }
}


/// <summary>
/// Used to inject dependencies that require dropdown choice values.
/// Understood to be uniquely a source of choices appropriate for a valid <seealso cref="DistributionPolicyCode"/>.
/// </summary>
public partial interface IDistributionPolicyCodeDropdownSource : IDropdownDataSource<IDistributionPolicyCodeDropdownRow>
{
}


/// <summary>
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDistributionPolicyCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
public partial class DistributionPolicyCodeDropdownSource : EnumMetadataManager<DistributionPolicyCode,IDistributionPolicyCodeDropdownRow,DistributionPolicyCodeDropdownRow>
{
    public DistributionPolicyCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DistributionPolicyCodeDropdownRow(enumValue, memberInfo))
    {
    }
}

