﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentCancellationRejection1Code.  ISO2002 ID# _zb9ZoA93EeGeV5vP7Mvdig_-151965379.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Returned when a request for cancellation cannot be executed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentCancellationRejection1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_zb9ZoA93EeGeV5vP7Mvdig_-151965379")]
public partial class PaymentCancellationRejection1CodeDropdownSource : EnumMetadataManager<PaymentCancellationRejection1Code,IPaymentCancellationRejection1CodeDropdownRow,PaymentCancellationRejection1CodeDropdownRow>
{
    public PaymentCancellationRejection1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentCancellationRejection1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
