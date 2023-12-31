﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PaymentMethod6Code.  ISO2002 ID# _Z0kPZtp-Ed-ak6NoX_4Aeg_1534180341.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the method of payment.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PaymentMethod6CodeDropdownSource"/>.
/// Implements <seealso cref="IPaymentMethod6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z0kPZtp-Ed-ak6NoX_4Aeg_1534180341")]
public partial class PaymentMethod6CodeDropdownRow : EnumMetadataItem<PaymentMethod6Code>, IPaymentMethod6CodeDropdownRow
{
    /// <summary>
    /// Specifies the method of payment.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PaymentMethod6CodeDropdownRow(PaymentMethod6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
