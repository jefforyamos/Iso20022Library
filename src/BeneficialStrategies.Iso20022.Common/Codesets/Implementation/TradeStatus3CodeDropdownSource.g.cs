﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeStatus3Code.  ISO2002 ID# _TRnmmAEcEeCQm6a_G2yO_w_525185238.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a trade in a central matching and settlement system.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeStatus3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TRnmmAEcEeCQm6a_G2yO_w_525185238")]
public partial class TradeStatus3CodeDropdownSource : EnumMetadataManager<TradeStatus3Code,ITradeStatus3CodeDropdownRow,TradeStatus3CodeDropdownRow>
{
    public TradeStatus3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeStatus3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
