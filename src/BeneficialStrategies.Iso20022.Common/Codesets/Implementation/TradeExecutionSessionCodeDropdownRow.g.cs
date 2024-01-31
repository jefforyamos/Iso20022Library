﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TradeExecutionSessionCode.  ISO2002 ID# _YmerpNp-Ed-ak6NoX_4Aeg_336259624.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Represents a specific market trading session. It is used to identify a portion of the session where the execution might take place ("after market", "pre-market").|It is used to support order routing, quoting, and trade and market data reporting. For instance, orders can be routed to one or more Trading Sessions. Examples of Trading Session usage may be to facilitate extended hours trading, to differentiate between concurrent electronic and open-outcry trading, or to differentiate block and/or oddlot trading.|It is used by Exchanges, ECN's, and ATS's.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TradeExecutionSessionCodeDropdownSource"/>.
/// Implements <seealso cref="ITradeExecutionSessionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YmerpNp-Ed-ak6NoX_4Aeg_336259624")]
public partial class TradeExecutionSessionCodeDropdownRow : EnumMetadataItem<TradeExecutionSessionCode>, ITradeExecutionSessionCodeDropdownRow
{
    /// <summary>
    /// Represents a specific market trading session. It is used to identify a portion of the session where the execution might take place ("after market", "pre-market").|It is used to support order routing, quoting, and trade and market data reporting. For instance, orders can be routed to one or more Trading Sessions. Examples of Trading Session usage may be to facilitate extended hours trading, to differentiate between concurrent electronic and open-outcry trading, or to differentiate block and/or oddlot trading.|It is used by Exchanges, ECN's, and ATS's.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TradeExecutionSessionCodeDropdownRow(TradeExecutionSessionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
