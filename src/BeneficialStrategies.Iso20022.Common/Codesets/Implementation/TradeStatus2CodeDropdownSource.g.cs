﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeStatus2Code.  ISO2002 ID# _Vp_FV9p-Ed-ak6NoX_4Aeg_1212704740.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a trade in a central matching and settlement system.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeStatus2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Vp_FV9p-Ed-ak6NoX_4Aeg_1212704740")]
public partial class TradeStatus2CodeDropdownSource : EnumMetadataManager<TradeStatus2Code,ITradeStatus2CodeDropdownRow,TradeStatus2CodeDropdownRow>
{
    public TradeStatus2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeStatus2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
