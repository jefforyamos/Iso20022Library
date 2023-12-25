﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeCounterpartyTypeCode.  ISO2002 ID# _5cohQCR7Ee2VuKUpJ7HXPg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the trade counterparty.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeCounterpartyTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_5cohQCR7Ee2VuKUpJ7HXPg")]
public partial class TradeCounterpartyTypeCodeDropdownSource : EnumMetadataManager<TradeCounterpartyTypeCode,ITradeCounterpartyTypeCodeDropdownRow,TradeCounterpartyTypeCodeDropdownRow>
{
    public TradeCounterpartyTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeCounterpartyTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
