﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementTransactionConditionV2Code.  ISO2002 ID# __uywsNojEeC60axPepSq7g_-615097257.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementTransactionConditionV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__uywsNojEeC60axPepSq7g_-615097257")]
public partial class SettlementTransactionConditionV2CodeDropdownSource : EnumMetadataManager<SettlementTransactionConditionV2Code,ISettlementTransactionConditionV2CodeDropdownRow,SettlementTransactionConditionV2CodeDropdownRow>
{
    public SettlementTransactionConditionV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementTransactionConditionV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
