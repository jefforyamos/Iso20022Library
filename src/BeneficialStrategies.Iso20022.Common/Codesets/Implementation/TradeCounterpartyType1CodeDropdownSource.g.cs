﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeCounterpartyType1Code.  ISO2002 ID# _Y0Kk0CR8Ee2VuKUpJ7HXPg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the trade counterparty.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeCounterpartyType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y0Kk0CR8Ee2VuKUpJ7HXPg")]
public partial class TradeCounterpartyType1CodeDropdownSource : EnumMetadataManager<TradeCounterpartyType1Code,ITradeCounterpartyType1CodeDropdownRow,TradeCounterpartyType1CodeDropdownRow>
{
    public TradeCounterpartyType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeCounterpartyType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
