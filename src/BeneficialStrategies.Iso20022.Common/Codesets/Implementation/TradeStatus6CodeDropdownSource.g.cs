﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeStatus6Code.  ISO2002 ID# _krjDEZU7EeaYkf5FCqYMeA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a trade in a central matching and settlement system.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeStatus6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_krjDEZU7EeaYkf5FCqYMeA")]
public partial class TradeStatus6CodeDropdownSource : EnumMetadataManager<TradeStatus6Code,ITradeStatus6CodeDropdownRow,TradeStatus6CodeDropdownRow>
{
    public TradeStatus6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeStatus6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
