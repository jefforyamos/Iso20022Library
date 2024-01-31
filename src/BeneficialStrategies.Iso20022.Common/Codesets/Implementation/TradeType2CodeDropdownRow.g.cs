﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TradeType2Code.  ISO2002 ID# _YqDkF9p-Ed-ak6NoX_4Aeg_-897262325.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of executed order in a bidding process.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TradeType2CodeDropdownSource"/>.
/// Implements <seealso cref="ITradeType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YqDkF9p-Ed-ak6NoX_4Aeg_-897262325")]
public partial class TradeType2CodeDropdownRow : EnumMetadataItem<TradeType2Code>, ITradeType2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of executed order in a bidding process.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TradeType2CodeDropdownRow(TradeType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
