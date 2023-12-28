﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentPurpose1Code.  ISO2002 ID# _Z5CfuNp-Ed-ak6NoX_4Aeg_148233450.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of transaction that resulted in a payment initiation.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentPurpose1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z5CfuNp-Ed-ak6NoX_4Aeg_148233450")]
public partial class PaymentPurpose1CodeDropdownSource : EnumMetadataManager<PaymentPurpose1Code,IPaymentPurpose1CodeDropdownRow,PaymentPurpose1CodeDropdownRow>
{
    public PaymentPurpose1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentPurpose1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
