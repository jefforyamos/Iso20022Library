﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeMarketCode.  ISO2002 ID# _tVVDYKcAEeSyQqZ4APDtOA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a code for a trade market.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeMarketCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_tVVDYKcAEeSyQqZ4APDtOA")]
public partial class TradeMarketCodeDropdownSource : EnumMetadataManager<TradeMarketCode,ITradeMarketCodeDropdownRow,TradeMarketCodeDropdownRow>
{
    public TradeMarketCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeMarketCodeDropdownRow(enumValue, memberInfo))
    {
    }
}