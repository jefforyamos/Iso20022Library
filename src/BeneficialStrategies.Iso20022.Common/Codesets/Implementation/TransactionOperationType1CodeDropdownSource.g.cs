﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionOperationType1Code.  ISO2002 ID# _8-aicJfpEeSfnc-VXAEapg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of process related to a specific transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionOperationType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8-aicJfpEeSfnc-VXAEapg")]
public partial class TransactionOperationType1CodeDropdownSource : EnumMetadataManager<TransactionOperationType1Code,ITransactionOperationType1CodeDropdownRow,TransactionOperationType1CodeDropdownRow>
{
    public TransactionOperationType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionOperationType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
