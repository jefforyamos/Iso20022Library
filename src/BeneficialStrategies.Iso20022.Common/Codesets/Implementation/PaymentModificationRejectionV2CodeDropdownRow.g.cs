﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PaymentModificationRejectionV2Code.  ISO2002 ID# _Z4u9sNp-Ed-ak6NoX_4Aeg_-2057540990.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the reject of a modification request.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PaymentModificationRejectionV2CodeDropdownSource"/>.
/// Implements <seealso cref="IPaymentModificationRejectionV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z4u9sNp-Ed-ak6NoX_4Aeg_-2057540990")]
public partial class PaymentModificationRejectionV2CodeDropdownRow : EnumMetadataItem<PaymentModificationRejectionV2Code>, IPaymentModificationRejectionV2CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for the reject of a modification request.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PaymentModificationRejectionV2CodeDropdownRow(PaymentModificationRejectionV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
