﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesTransactionType19Code.  ISO2002 ID# _C0Bo6qUbEee4_75LDmHZiQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies underlying information regarding the type of transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesTransactionType19CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_C0Bo6qUbEee4_75LDmHZiQ")]
public partial class SecuritiesTransactionType19CodeDropdownSource : EnumMetadataManager<SecuritiesTransactionType19Code,ISecuritiesTransactionType19CodeDropdownRow,SecuritiesTransactionType19CodeDropdownRow>
{
    public SecuritiesTransactionType19CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesTransactionType19CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
