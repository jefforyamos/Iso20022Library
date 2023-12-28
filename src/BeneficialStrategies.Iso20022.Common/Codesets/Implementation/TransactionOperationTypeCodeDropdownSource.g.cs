﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionOperationTypeCode.  ISO2002 ID# _0tTA3JfpEeSfnc-VXAEapg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of process related to a specific transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionOperationTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0tTA3JfpEeSfnc-VXAEapg")]
public partial class TransactionOperationTypeCodeDropdownSource : EnumMetadataManager<TransactionOperationTypeCode,ITransactionOperationTypeCodeDropdownRow,TransactionOperationTypeCodeDropdownRow>
{
    public TransactionOperationTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionOperationTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}