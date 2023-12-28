﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TradeMarket2Code.  ISO2002 ID# _m4hZMJhyEeumhIk_Pv20Lg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a code for a trade market.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TradeMarket2CodeDropdownSource"/>.
/// Implements <seealso cref="ITradeMarket2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_m4hZMJhyEeumhIk_Pv20Lg")]
public partial class TradeMarket2CodeDropdownRow : EnumMetadataItem<TradeMarket2Code>, ITradeMarket2CodeDropdownRow
{
    /// <summary>
    /// Specifies a code for a trade market.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TradeMarket2CodeDropdownRow(TradeMarket2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}