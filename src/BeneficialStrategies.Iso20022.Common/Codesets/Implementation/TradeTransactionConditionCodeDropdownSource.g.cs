﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeTransactionConditionCode.  ISO2002 ID# _YpT9Mtp-Ed-ak6NoX_4Aeg_-1512742367.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the conditions under which the order/trade is to be/was executed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeTransactionConditionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YpT9Mtp-Ed-ak6NoX_4Aeg_-1512742367")]
public partial class TradeTransactionConditionCodeDropdownSource : EnumMetadataManager<TradeTransactionConditionCode,ITradeTransactionConditionCodeDropdownRow,TradeTransactionConditionCodeDropdownRow>
{
    public TradeTransactionConditionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeTransactionConditionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}