﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeStatus4Code.  ISO2002 ID# _TRxXkwEcEeCQm6a_G2yO_w_-1947511446.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a trade in a central matching and settlement system.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeStatus4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TRxXkwEcEeCQm6a_G2yO_w_-1947511446")]
public partial class TradeStatus4CodeDropdownSource : EnumMetadataManager<TradeStatus4Code,ITradeStatus4CodeDropdownRow,TradeStatus4CodeDropdownRow>
{
    public TradeStatus4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeStatus4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}