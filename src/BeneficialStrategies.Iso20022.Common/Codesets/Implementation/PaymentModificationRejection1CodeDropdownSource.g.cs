﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for PaymentModificationRejection1Code.  ISO2002 ID# _Z0uAZ9p-Ed-ak6NoX_4Aeg_-1179991966.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the reason for rejecting a modification.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IPaymentModificationRejection1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z0uAZ9p-Ed-ak6NoX_4Aeg_-1179991966")]
public partial class PaymentModificationRejection1CodeDropdownSource : EnumMetadataManager<PaymentModificationRejection1Code,IPaymentModificationRejection1CodeDropdownRow,PaymentModificationRejection1CodeDropdownRow>
{
    public PaymentModificationRejection1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new PaymentModificationRejection1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
