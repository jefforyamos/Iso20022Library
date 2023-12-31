﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementTransactionCondition14Code.  ISO2002 ID# _RB7AOQzXEeuUZuaHWzkTew.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementTransactionCondition14CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_RB7AOQzXEeuUZuaHWzkTew")]
public partial class SettlementTransactionCondition14CodeDropdownSource : EnumMetadataManager<SettlementTransactionCondition14Code,ISettlementTransactionCondition14CodeDropdownRow,SettlementTransactionCondition14CodeDropdownRow>
{
    public SettlementTransactionCondition14CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementTransactionCondition14CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
