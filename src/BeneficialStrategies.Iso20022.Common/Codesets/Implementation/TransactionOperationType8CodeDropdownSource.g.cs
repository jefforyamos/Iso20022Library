﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionOperationType8Code.  ISO2002 ID# _CsZNMImAEeyFq4U1cYKupg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transaction operation action type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionOperationType8CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_CsZNMImAEeyFq4U1cYKupg")]
public partial class TransactionOperationType8CodeDropdownSource : EnumMetadataManager<TransactionOperationType8Code,ITransactionOperationType8CodeDropdownRow,TransactionOperationType8CodeDropdownRow>
{
    public TransactionOperationType8CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionOperationType8CodeDropdownRow(enumValue, memberInfo))
    {
    }
}