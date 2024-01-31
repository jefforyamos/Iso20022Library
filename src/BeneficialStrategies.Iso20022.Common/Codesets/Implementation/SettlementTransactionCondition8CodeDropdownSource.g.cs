﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SettlementTransactionCondition8Code.  ISO2002 ID# _nTE_cfvzEeC5cppCUzSD9A.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISettlementTransactionCondition8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nTE_cfvzEeC5cppCUzSD9A")]
public partial class SettlementTransactionCondition8CodeDropdownSource : EnumMetadataManager<SettlementTransactionCondition8Code,ISettlementTransactionCondition8CodeDropdownRow,SettlementTransactionCondition8CodeDropdownRow>
{
    public SettlementTransactionCondition8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SettlementTransactionCondition8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
