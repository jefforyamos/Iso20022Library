﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TradeStatus4Code.  ISO2002 ID# _TRxXkwEcEeCQm6a_G2yO_w_-1947511446.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a trade in a central matching and settlement system.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TradeStatus4CodeDropdownSource"/>.
/// Implements <seealso cref="ITradeStatus4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TRxXkwEcEeCQm6a_G2yO_w_-1947511446")]
public partial class TradeStatus4CodeDropdownRow : EnumMetadataItem<TradeStatus4Code>, ITradeStatus4CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a trade in a central matching and settlement system.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TradeStatus4CodeDropdownRow(TradeStatus4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
