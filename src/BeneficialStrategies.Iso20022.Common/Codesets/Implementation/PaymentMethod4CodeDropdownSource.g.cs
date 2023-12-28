﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentMethod4Code.  ISO2002 ID# _Z0kPYdp-Ed-ak6NoX_4Aeg_-2121115820.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transfer method that will be used to transfer an amount of money.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentMethod4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z0kPYdp-Ed-ak6NoX_4Aeg_-2121115820")]
public partial class PaymentMethod4CodeDropdownSource : EnumMetadataManager<PaymentMethod4Code,IPaymentMethod4CodeDropdownRow,PaymentMethod4CodeDropdownRow>
{
    public PaymentMethod4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentMethod4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
