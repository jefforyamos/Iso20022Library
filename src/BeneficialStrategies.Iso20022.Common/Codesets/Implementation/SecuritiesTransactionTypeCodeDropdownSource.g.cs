﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesTransactionTypeCode.  ISO2002 ID# _ZIwSQtp-Ed-ak6NoX_4Aeg_-1421887384.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesTransactionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZIwSQtp-Ed-ak6NoX_4Aeg_-1421887384")]
public partial class SecuritiesTransactionTypeCodeDropdownSource : EnumMetadataManager<SecuritiesTransactionTypeCode,ISecuritiesTransactionTypeCodeDropdownRow,SecuritiesTransactionTypeCodeDropdownRow>
{
    public SecuritiesTransactionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesTransactionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
