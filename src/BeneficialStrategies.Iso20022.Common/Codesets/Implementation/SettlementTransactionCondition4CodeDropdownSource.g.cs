﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementTransactionCondition4Code.  ISO2002 ID# _BbQ2gd0hEd-Cb-IGbQ4hBQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementTransactionCondition4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_BbQ2gd0hEd-Cb-IGbQ4hBQ")]
public partial class SettlementTransactionCondition4CodeDropdownSource : EnumMetadataManager<SettlementTransactionCondition4Code,ISettlementTransactionCondition4CodeDropdownRow,SettlementTransactionCondition4CodeDropdownRow>
{
    public SettlementTransactionCondition4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementTransactionCondition4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
