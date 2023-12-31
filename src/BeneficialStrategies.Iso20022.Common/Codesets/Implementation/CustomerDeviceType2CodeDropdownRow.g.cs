﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CustomerDeviceType2Code.  ISO2002 ID# _GYK4MZfJEeuqNYk2TG3bTg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of customer device.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CustomerDeviceType2CodeDropdownSource"/>.
/// Implements <seealso cref="ICustomerDeviceType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_GYK4MZfJEeuqNYk2TG3bTg")]
public partial class CustomerDeviceType2CodeDropdownRow : EnumMetadataItem<CustomerDeviceType2Code>, ICustomerDeviceType2CodeDropdownRow
{
    /// <summary>
    /// Type of customer device.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CustomerDeviceType2CodeDropdownRow(CustomerDeviceType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
