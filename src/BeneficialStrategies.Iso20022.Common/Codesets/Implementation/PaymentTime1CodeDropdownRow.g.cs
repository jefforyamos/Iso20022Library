﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PaymentTime1Code.  ISO2002 ID# _Z7kPQ9p-Ed-ak6NoX_4Aeg_381154806.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the payment conditions.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PaymentTime1CodeDropdownSource"/>.
/// Implements <seealso cref="IPaymentTime1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z7kPQ9p-Ed-ak6NoX_4Aeg_381154806")]
public partial class PaymentTime1CodeDropdownRow : EnumMetadataItem<PaymentTime1Code>, IPaymentTime1CodeDropdownRow
{
    /// <summary>
    /// Specifies the payment conditions.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PaymentTime1CodeDropdownRow(PaymentTime1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
