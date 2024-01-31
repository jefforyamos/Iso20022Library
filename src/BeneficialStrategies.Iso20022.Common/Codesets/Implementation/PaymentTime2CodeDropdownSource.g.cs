﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentTime2Code.  ISO2002 ID# _Z7uAQtp-Ed-ak6NoX_4Aeg_1319644743.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the payment conditions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentTime2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z7uAQtp-Ed-ak6NoX_4Aeg_1319644743")]
public partial class PaymentTime2CodeDropdownSource : EnumMetadataManager<PaymentTime2Code,IPaymentTime2CodeDropdownRow,PaymentTime2CodeDropdownRow>
{
    public PaymentTime2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentTime2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
