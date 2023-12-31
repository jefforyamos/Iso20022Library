﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PaymentTransactionState1Code.  ISO2002 ID# _Wlue0KHnEeagRbKvRt3LnA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the different states which a payment transaction can be in.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PaymentTransactionState1CodeDropdownSource"/>.
/// Implements <seealso cref="IPaymentTransactionState1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Wlue0KHnEeagRbKvRt3LnA")]
public partial class PaymentTransactionState1CodeDropdownRow : EnumMetadataItem<PaymentTransactionState1Code>, IPaymentTransactionState1CodeDropdownRow
{
    /// <summary>
    /// Contains the different states which a payment transaction can be in.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PaymentTransactionState1CodeDropdownRow(PaymentTransactionState1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
