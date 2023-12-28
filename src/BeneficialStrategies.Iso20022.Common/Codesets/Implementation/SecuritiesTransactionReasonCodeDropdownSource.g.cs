﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesTransactionReasonCode.  ISO2002 ID# _ZGOisNp-Ed-ak6NoX_4Aeg_464976126.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the reason why the transaction has a specific status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesTransactionReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZGOisNp-Ed-ak6NoX_4Aeg_464976126")]
public partial class SecuritiesTransactionReasonCodeDropdownSource : EnumMetadataManager<SecuritiesTransactionReasonCode,ISecuritiesTransactionReasonCodeDropdownRow,SecuritiesTransactionReasonCodeDropdownRow>
{
    public SecuritiesTransactionReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesTransactionReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}