﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentMethod7Code.  ISO2002 ID# _YbT9dNp-Ed-ak6NoX_4Aeg_698889928.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the transfer method that will be used to transfer the cash.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentMethod7CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YbT9dNp-Ed-ak6NoX_4Aeg_698889928")]
public partial class PaymentMethod7CodeDropdownSource : EnumMetadataManager<PaymentMethod7Code,IPaymentMethod7CodeDropdownRow,PaymentMethod7CodeDropdownRow>
{
    public PaymentMethod7CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentMethod7CodeDropdownRow(enumValue, memberInfo))
    {
    }
}