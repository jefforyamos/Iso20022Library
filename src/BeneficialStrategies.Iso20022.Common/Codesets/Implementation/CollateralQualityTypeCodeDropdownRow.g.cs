﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CollateralQualityTypeCode.  ISO2002 ID# _LBcKoC7YEea1cMkrGwA6Gg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the classification of the risk of the security used as collateral.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CollateralQualityTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ICollateralQualityTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_LBcKoC7YEea1cMkrGwA6Gg")]
public partial class CollateralQualityTypeCodeDropdownRow : EnumMetadataItem<CollateralQualityTypeCode>, ICollateralQualityTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the classification of the risk of the security used as collateral.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CollateralQualityTypeCodeDropdownRow(CollateralQualityTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
