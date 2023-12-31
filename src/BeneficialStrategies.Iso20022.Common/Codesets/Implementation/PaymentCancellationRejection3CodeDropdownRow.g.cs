﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PaymentCancellationRejection3Code.  ISO2002 ID# _p8qMgB09EeiYoZGjIMHr2A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Returned when a request for cancellation cannot be executed.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PaymentCancellationRejection3CodeDropdownSource"/>.
/// Implements <seealso cref="IPaymentCancellationRejection3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_p8qMgB09EeiYoZGjIMHr2A")]
public partial class PaymentCancellationRejection3CodeDropdownRow : EnumMetadataItem<PaymentCancellationRejection3Code>, IPaymentCancellationRejection3CodeDropdownRow
{
    /// <summary>
    /// Returned when a request for cancellation cannot be executed.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PaymentCancellationRejection3CodeDropdownRow(PaymentCancellationRejection3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
