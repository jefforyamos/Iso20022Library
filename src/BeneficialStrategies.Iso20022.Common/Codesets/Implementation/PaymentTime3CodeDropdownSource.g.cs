﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentTime3Code.  ISO2002 ID# _56RpYNP7EeK0PPbKncCqzA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the payment conditions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentTime3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_56RpYNP7EeK0PPbKncCqzA")]
public partial class PaymentTime3CodeDropdownSource : EnumMetadataManager<PaymentTime3Code,IPaymentTime3CodeDropdownRow,PaymentTime3CodeDropdownRow>
{
    public PaymentTime3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentTime3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
