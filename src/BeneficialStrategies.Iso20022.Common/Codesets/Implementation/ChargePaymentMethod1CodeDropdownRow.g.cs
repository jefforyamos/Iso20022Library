﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ChargePaymentMethod1Code.  ISO2002 ID# _ZFE3gBXyEeOBE-jZfcm4KQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how expenses are paid.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ChargePaymentMethod1CodeDropdownSource"/>.
/// Implements <seealso cref="IChargePaymentMethod1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZFE3gBXyEeOBE-jZfcm4KQ")]
public partial class ChargePaymentMethod1CodeDropdownRow : EnumMetadataItem<ChargePaymentMethod1Code>, IChargePaymentMethod1CodeDropdownRow
{
    /// <summary>
    /// Specifies how expenses are paid.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ChargePaymentMethod1CodeDropdownRow(ChargePaymentMethod1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
