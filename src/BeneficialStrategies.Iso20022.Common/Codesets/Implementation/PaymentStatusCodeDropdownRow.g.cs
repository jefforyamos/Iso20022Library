﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PaymentStatusCode.  ISO2002 ID# _Z7RUV9p-Ed-ak6NoX_4Aeg_-481257913.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the status of a single payment transaction or of a group of payment transactions.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PaymentStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IPaymentStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z7RUV9p-Ed-ak6NoX_4Aeg_-481257913")]
public partial class PaymentStatusCodeDropdownRow : EnumMetadataItem<PaymentStatusCode>, IPaymentStatusCodeDropdownRow
{
    /// <summary>
    /// Indicates the status of a single payment transaction or of a group of payment transactions.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PaymentStatusCodeDropdownRow(PaymentStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
