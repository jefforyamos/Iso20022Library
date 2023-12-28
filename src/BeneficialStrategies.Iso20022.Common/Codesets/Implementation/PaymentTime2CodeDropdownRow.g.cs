﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PaymentTime2Code.  ISO2002 ID# _Z7uAQtp-Ed-ak6NoX_4Aeg_1319644743.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the payment conditions.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PaymentTime2CodeDropdownSource"/>.
/// Implements <seealso cref="IPaymentTime2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z7uAQtp-Ed-ak6NoX_4Aeg_1319644743")]
public partial class PaymentTime2CodeDropdownRow : EnumMetadataItem<PaymentTime2Code>, IPaymentTime2CodeDropdownRow
{
    /// <summary>
    /// Specifies the payment conditions.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PaymentTime2CodeDropdownRow(PaymentTime2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}