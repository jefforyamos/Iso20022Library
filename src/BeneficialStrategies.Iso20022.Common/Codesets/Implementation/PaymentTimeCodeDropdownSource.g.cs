﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentTimeCode.  ISO2002 ID# _Z73xQ9p-Ed-ak6NoX_4Aeg_-2012418215.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the payment conditions.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentTimeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z73xQ9p-Ed-ak6NoX_4Aeg_-2012418215")]
public partial class PaymentTimeCodeDropdownSource : EnumMetadataManager<PaymentTimeCode,IPaymentTimeCodeDropdownRow,PaymentTimeCodeDropdownRow>
{
    public PaymentTimeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentTimeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
