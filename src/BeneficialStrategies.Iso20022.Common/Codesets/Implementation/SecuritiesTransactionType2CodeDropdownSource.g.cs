﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesTransactionType2Code.  ISO2002 ID# _ZG-JkNp-Ed-ak6NoX_4Aeg_519121104.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesTransactionType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZG-JkNp-Ed-ak6NoX_4Aeg_519121104")]
public partial class SecuritiesTransactionType2CodeDropdownSource : EnumMetadataManager<SecuritiesTransactionType2Code,ISecuritiesTransactionType2CodeDropdownRow,SecuritiesTransactionType2CodeDropdownRow>
{
    public SecuritiesTransactionType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesTransactionType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
