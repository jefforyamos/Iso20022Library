﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentCategoryPurposeCode.  ISO2002 ID# _ZzX8ldp-Ed-ak6NoX_4Aeg_-191357927.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of transaction that resulted in the payment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentCategoryPurposeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZzX8ldp-Ed-ak6NoX_4Aeg_-191357927")]
public partial class PaymentCategoryPurposeCodeDropdownSource : EnumMetadataManager<PaymentCategoryPurposeCode,IPaymentCategoryPurposeCodeDropdownRow,PaymentCategoryPurposeCodeDropdownRow>
{
    public PaymentCategoryPurposeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentCategoryPurposeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
