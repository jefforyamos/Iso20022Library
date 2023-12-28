﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TradingCapacityCode.  ISO2002 ID# _YqqBBtp-Ed-ak6NoX_4Aeg_-1705783512.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the role of a trading party in a transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TradingCapacityCodeDropdownSource"/>.
/// Implements <seealso cref="ITradingCapacityCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YqqBBtp-Ed-ak6NoX_4Aeg_-1705783512")]
public partial class TradingCapacityCodeDropdownRow : EnumMetadataItem<TradingCapacityCode>, ITradingCapacityCodeDropdownRow
{
    /// <summary>
    /// Specifies the role of a trading party in a transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TradingCapacityCodeDropdownRow(TradingCapacityCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}