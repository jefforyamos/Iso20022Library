﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionProcessingStatus1Code.  ISO2002 ID# _YsAE2Np-Ed-ak6NoX_4Aeg_-482977155.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the processing status of a transaction (at account servicer level).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionProcessingStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YsAE2Np-Ed-ak6NoX_4Aeg_-482977155")]
public partial class TransactionProcessingStatus1CodeDropdownSource : EnumMetadataManager<TransactionProcessingStatus1Code,ITransactionProcessingStatus1CodeDropdownRow,TransactionProcessingStatus1CodeDropdownRow>
{
    public TransactionProcessingStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionProcessingStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
