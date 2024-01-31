﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentCategoryPurpose1Code.  ISO2002 ID# _ZzFBo9p-Ed-ak6NoX_4Aeg_11813322.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of transaction that resulted in the payment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentCategoryPurpose1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZzFBo9p-Ed-ak6NoX_4Aeg_11813322")]
public partial class PaymentCategoryPurpose1CodeDropdownSource : EnumMetadataManager<PaymentCategoryPurpose1Code,IPaymentCategoryPurpose1CodeDropdownRow,PaymentCategoryPurpose1CodeDropdownRow>
{
    public PaymentCategoryPurpose1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentCategoryPurpose1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
