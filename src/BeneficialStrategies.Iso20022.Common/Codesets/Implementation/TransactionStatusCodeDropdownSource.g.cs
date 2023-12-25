﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TransactionStatusCode.  ISO2002 ID# _YuO5ddp-Ed-ak6NoX_4Aeg_-163376568.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the processing status of an investment fund transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITransactionStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YuO5ddp-Ed-ak6NoX_4Aeg_-163376568")]
public partial class TransactionStatusCodeDropdownSource : EnumMetadataManager<TransactionStatusCode,ITransactionStatusCodeDropdownRow,TransactionStatusCodeDropdownRow>
{
    public TransactionStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TransactionStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
