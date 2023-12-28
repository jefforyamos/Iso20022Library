﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TradeTransactionCondition4Code.  ISO2002 ID# _Yo3RSdp-Ed-ak6NoX_4Aeg_-230430726.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions under which the order/trade is to be/was executed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITradeTransactionCondition4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yo3RSdp-Ed-ak6NoX_4Aeg_-230430726")]
public partial class TradeTransactionCondition4CodeDropdownSource : EnumMetadataManager<TradeTransactionCondition4Code,ITradeTransactionCondition4CodeDropdownRow,TradeTransactionCondition4CodeDropdownRow>
{
    public TradeTransactionCondition4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TradeTransactionCondition4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}