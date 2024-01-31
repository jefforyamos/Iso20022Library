﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalPaymentTransactionStatusCode.  ISO2002 ID# _mTPNQLf8Eee9KIDjEHK7ZQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an individual payment instructions, as published in an external payment transaction status code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalPaymentTransactionStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_mTPNQLf8Eee9KIDjEHK7ZQ")]
public partial class ExternalPaymentTransactionStatusCodeDropdownSource : EnumMetadataManager<ExternalPaymentTransactionStatusCode,IExternalPaymentTransactionStatusCodeDropdownRow,ExternalPaymentTransactionStatusCodeDropdownRow>
{
    public ExternalPaymentTransactionStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalPaymentTransactionStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
