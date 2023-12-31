﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionProcessingStatus2Code.  ISO2002 ID# _YsJOxtp-Ed-ak6NoX_4Aeg_1783969936.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the processing status of a transaction (at account servicer level).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionProcessingStatus2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YsJOxtp-Ed-ak6NoX_4Aeg_1783969936")]
public partial class TransactionProcessingStatus2CodeDropdownSource : EnumMetadataManager<TransactionProcessingStatus2Code,ITransactionProcessingStatus2CodeDropdownRow,TransactionProcessingStatus2CodeDropdownRow>
{
    public TransactionProcessingStatus2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionProcessingStatus2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
