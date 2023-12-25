﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CollateralTypeCode.  ISO2002 ID# _a_0hldp-Ed-ak6NoX_4Aeg_591395154.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of collateral.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CollateralTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ICollateralTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a_0hldp-Ed-ak6NoX_4Aeg_591395154")]
public partial class CollateralTypeCodeDropdownRow : EnumMetadataItem<CollateralTypeCode>, ICollateralTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of collateral.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CollateralTypeCodeDropdownRow(CollateralTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
