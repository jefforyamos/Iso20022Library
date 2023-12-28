﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeMarket1Code.  ISO2002 ID# _2jl30KcCEeSyQqZ4APDtOA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a code for a trade market.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeMarket1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2jl30KcCEeSyQqZ4APDtOA")]
public partial class TradeMarket1CodeDropdownSource : EnumMetadataManager<TradeMarket1Code,ITradeMarket1CodeDropdownRow,TradeMarket1CodeDropdownRow>
{
    public TradeMarket1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeMarket1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
