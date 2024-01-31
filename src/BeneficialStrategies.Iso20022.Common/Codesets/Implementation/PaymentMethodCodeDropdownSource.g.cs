﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentMethodCode.  ISO2002 ID# _Z0uAYNp-Ed-ak6NoX_4Aeg_2143732969.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transfer method that will be used to transfer the cash.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentMethodCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z0uAYNp-Ed-ak6NoX_4Aeg_2143732969")]
public partial class PaymentMethodCodeDropdownSource : EnumMetadataManager<PaymentMethodCode,IPaymentMethodCodeDropdownRow,PaymentMethodCodeDropdownRow>
{
    public PaymentMethodCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentMethodCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
