﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Payment1Code.  ISO2002 ID# _Zy7Qptp-Ed-ak6NoX_4Aeg_1133077707.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of payment.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Payment1CodeDropdownSource"/>.
/// Implements <seealso cref="IPayment1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Zy7Qptp-Ed-ak6NoX_4Aeg_1133077707")]
public partial class Payment1CodeDropdownRow : EnumMetadataItem<Payment1Code>, IPayment1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of payment.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Payment1CodeDropdownRow(Payment1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
