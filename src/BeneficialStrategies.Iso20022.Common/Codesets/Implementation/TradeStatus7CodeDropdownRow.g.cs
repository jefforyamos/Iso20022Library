﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TradeStatus7Code.  ISO2002 ID# _2s_Z0ZU8EeaYkf5FCqYMeA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a trade in a central matching and settlement system.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TradeStatus7CodeDropdownSource"/>.
/// Implements <seealso cref="ITradeStatus7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2s_Z0ZU8EeaYkf5FCqYMeA")]
public partial class TradeStatus7CodeDropdownRow : EnumMetadataItem<TradeStatus7Code>, ITradeStatus7CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of a trade in a central matching and settlement system.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TradeStatus7CodeDropdownRow(TradeStatus7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
