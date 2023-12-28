﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentType4Code.  ISO2002 ID# _8ibGUOkAEemV35DUs8L82Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type, or nature, of the payment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentType4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8ibGUOkAEemV35DUs8L82Q")]
public partial class PaymentType4CodeDropdownSource : EnumMetadataManager<PaymentType4Code,IPaymentType4CodeDropdownRow,PaymentType4CodeDropdownRow>
{
    public PaymentType4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentType4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}