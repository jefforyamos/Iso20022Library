﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionOperationType4Code.  ISO2002 ID# _klf60Q1GEeaj35fzaZHUIg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction operation action type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionOperationType4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_klf60Q1GEeaj35fzaZHUIg")]
public partial class TransactionOperationType4CodeDropdownSource : EnumMetadataManager<TransactionOperationType4Code,ITransactionOperationType4CodeDropdownRow,TransactionOperationType4CodeDropdownRow>
{
    public TransactionOperationType4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionOperationType4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
