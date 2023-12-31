﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PaymentStatusReason1Code.  ISO2002 ID# _EbCioEJHEeinU6Cqu8f2Ow.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the reason for a payment status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PaymentStatusReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IPaymentStatusReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EbCioEJHEeinU6Cqu8f2Ow")]
public partial class PaymentStatusReason1CodeDropdownRow : EnumMetadataItem<PaymentStatusReason1Code>, IPaymentStatusReason1CodeDropdownRow
{
    /// <summary>
    /// Provides the reason for a payment status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PaymentStatusReason1CodeDropdownRow(PaymentStatusReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
