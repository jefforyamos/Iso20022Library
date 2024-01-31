﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeType2Code.  ISO2002 ID# _YqDkF9p-Ed-ak6NoX_4Aeg_-897262325.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of executed order in a bidding process.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YqDkF9p-Ed-ak6NoX_4Aeg_-897262325")]
public partial class TradeType2CodeDropdownSource : EnumMetadataManager<TradeType2Code,ITradeType2CodeDropdownRow,TradeType2CodeDropdownRow>
{
    public TradeType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
