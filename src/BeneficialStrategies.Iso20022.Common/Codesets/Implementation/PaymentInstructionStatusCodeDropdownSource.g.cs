﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentInstructionStatusCode.  ISO2002 ID# _Zzq3h9p-Ed-ak6NoX_4Aeg_676865279.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the state of a payment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentInstructionStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zzq3h9p-Ed-ak6NoX_4Aeg_676865279")]
public partial class PaymentInstructionStatusCodeDropdownSource : EnumMetadataManager<PaymentInstructionStatusCode,IPaymentInstructionStatusCodeDropdownRow,PaymentInstructionStatusCodeDropdownRow>
{
    public PaymentInstructionStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentInstructionStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}