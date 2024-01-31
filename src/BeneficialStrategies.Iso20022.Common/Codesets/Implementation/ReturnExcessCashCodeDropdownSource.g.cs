﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ReturnExcessCashCode.  ISO2002 ID# _F-c7MALdEeutW5-TpeYJhA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates if excess cash collateral in the currency is automatically returned as per the collateral provider’s Excess Cash Margin Instruction (colr.017).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IReturnExcessCashCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_F-c7MALdEeutW5-TpeYJhA")]
public partial class ReturnExcessCashCodeDropdownSource : EnumMetadataManager<ReturnExcessCashCode,IReturnExcessCashCodeDropdownRow,ReturnExcessCashCodeDropdownRow>
{
    public ReturnExcessCashCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ReturnExcessCashCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
