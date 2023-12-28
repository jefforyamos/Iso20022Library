﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CollateralPool1Code.  ISO2002 ID# _A695wN7GEeSaBeqd_btViQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the collateral is a pool collateral or not.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CollateralPool1CodeDropdownSource"/>.
/// Implements <seealso cref="ICollateralPool1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_A695wN7GEeSaBeqd_btViQ")]
public partial class CollateralPool1CodeDropdownRow : EnumMetadataItem<CollateralPool1Code>, ICollateralPool1CodeDropdownRow
{
    /// <summary>
    /// Specifies whether the collateral is a pool collateral or not.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CollateralPool1CodeDropdownRow(CollateralPool1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}