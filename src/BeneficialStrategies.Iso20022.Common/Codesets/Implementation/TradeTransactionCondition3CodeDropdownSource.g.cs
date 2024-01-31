﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeTransactionCondition3Code.  ISO2002 ID# _YobMYNp-Ed-ak6NoX_4Aeg_1891584902.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which the order/trade is to be/was executed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeTransactionCondition3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YobMYNp-Ed-ak6NoX_4Aeg_1891584902")]
public partial class TradeTransactionCondition3CodeDropdownSource : EnumMetadataManager<TradeTransactionCondition3Code,ITradeTransactionCondition3CodeDropdownRow,TradeTransactionCondition3CodeDropdownRow>
{
    public TradeTransactionCondition3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeTransactionCondition3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
