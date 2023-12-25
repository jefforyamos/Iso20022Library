﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PaymentPurposeCode.  ISO2002 ID# _Z5yGktp-Ed-ak6NoX_4Aeg_1855256934.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of transaction that resulted in a payment initiation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PaymentPurposeCodeDropdownSource"/>.
/// Implements <seealso cref="IPaymentPurposeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z5yGktp-Ed-ak6NoX_4Aeg_1855256934")]
public partial class PaymentPurposeCodeDropdownRow : EnumMetadataItem<PaymentPurposeCode>, IPaymentPurposeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of transaction that resulted in a payment initiation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PaymentPurposeCodeDropdownRow(PaymentPurposeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
