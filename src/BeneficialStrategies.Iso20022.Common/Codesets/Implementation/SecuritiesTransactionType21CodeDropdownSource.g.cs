﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for SecuritiesTransactionType21Code.  ISO2002 ID# _PZ7wxKUsEee4_75LDmHZiQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies underlying information regarding the type of transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ISecuritiesTransactionType21CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_PZ7wxKUsEee4_75LDmHZiQ")]
public partial class SecuritiesTransactionType21CodeDropdownSource : EnumMetadataManager<SecuritiesTransactionType21Code,ISecuritiesTransactionType21CodeDropdownRow,SecuritiesTransactionType21CodeDropdownRow>
{
    public SecuritiesTransactionType21CodeDropdownSource()
        : base( (enumValue, memberInfo) => new SecuritiesTransactionType21CodeDropdownRow(enumValue, memberInfo))
    {
    }
}