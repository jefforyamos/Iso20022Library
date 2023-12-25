﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementTransactionConditionCode.  ISO2002 ID# _ZNhdh9p-Ed-ak6NoX_4Aeg_885272360.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Collateral position is available for other purposes (for example, onwards delivery).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementTransactionConditionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZNhdh9p-Ed-ak6NoX_4Aeg_885272360")]
public partial class SettlementTransactionConditionCodeDropdownSource : EnumMetadataManager<SettlementTransactionConditionCode,ISettlementTransactionConditionCodeDropdownRow,SettlementTransactionConditionCodeDropdownRow>
{
    public SettlementTransactionConditionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementTransactionConditionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
