﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentCancellationStatusReasonCode.  ISO2002 ID# _OnEtsB04EeiYoZGjIMHr2A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides status reasons with regards to the cancellation of the payment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentCancellationStatusReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OnEtsB04EeiYoZGjIMHr2A")]
public partial class PaymentCancellationStatusReasonCodeDropdownSource : EnumMetadataManager<PaymentCancellationStatusReasonCode,IPaymentCancellationStatusReasonCodeDropdownRow,PaymentCancellationStatusReasonCodeDropdownRow>
{
    public PaymentCancellationStatusReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentCancellationStatusReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}