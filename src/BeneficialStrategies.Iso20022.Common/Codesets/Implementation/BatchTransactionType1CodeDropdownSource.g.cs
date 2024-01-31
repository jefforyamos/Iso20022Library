﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BatchTransactionType1Code.  ISO2002 ID# _KUq-g31DEeCF8NjrBemJWQ_-2092931546.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of transactions to include in a batch transfer.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBatchTransactionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KUq-g31DEeCF8NjrBemJWQ_-2092931546")]
public partial class BatchTransactionType1CodeDropdownSource : EnumMetadataManager<BatchTransactionType1Code,IBatchTransactionType1CodeDropdownRow,BatchTransactionType1CodeDropdownRow>
{
    public BatchTransactionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BatchTransactionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
