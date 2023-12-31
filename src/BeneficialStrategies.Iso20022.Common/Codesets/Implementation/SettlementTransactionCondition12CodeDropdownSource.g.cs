﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementTransactionCondition12Code.  ISO2002 ID# _2qssKQllEeuQ1MenzX1l-g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementTransactionCondition12CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2qssKQllEeuQ1MenzX1l-g")]
public partial class SettlementTransactionCondition12CodeDropdownSource : EnumMetadataManager<SettlementTransactionCondition12Code,ISettlementTransactionCondition12CodeDropdownRow,SettlementTransactionCondition12CodeDropdownRow>
{
    public SettlementTransactionCondition12CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementTransactionCondition12CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
