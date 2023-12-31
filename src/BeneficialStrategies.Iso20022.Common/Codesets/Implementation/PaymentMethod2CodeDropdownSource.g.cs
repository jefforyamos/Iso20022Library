﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentMethod2Code.  ISO2002 ID# _Z0aeYNp-Ed-ak6NoX_4Aeg_-15953636.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transfer method that will be used to transfer the cash.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentMethod2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z0aeYNp-Ed-ak6NoX_4Aeg_-15953636")]
public partial class PaymentMethod2CodeDropdownSource : EnumMetadataManager<PaymentMethod2Code,IPaymentMethod2CodeDropdownRow,PaymentMethod2CodeDropdownRow>
{
    public PaymentMethod2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentMethod2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
