﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CollateralPurposeCode.  ISO2002 ID# _YZXcuNp-Ed-ak6NoX_4Aeg_1268885357.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the collateral has been posted against the variation margin or the segregated independent amount.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CollateralPurposeCodeDropdownSource"/>.
/// Implements <seealso cref="ICollateralPurposeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YZXcuNp-Ed-ak6NoX_4Aeg_1268885357")]
public partial class CollateralPurposeCodeDropdownRow : EnumMetadataItem<CollateralPurposeCode>, ICollateralPurposeCodeDropdownRow
{
    /// <summary>
    /// Indicates whether the collateral has been posted against the variation margin or the segregated independent amount.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CollateralPurposeCodeDropdownRow(CollateralPurposeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
