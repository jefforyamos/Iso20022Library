﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CustomerOrderRequestCode.  ISO2002 ID# _ETkWwN6JEeiwsev40qZGEQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of customer orders that must be sent in response message.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CustomerOrderRequestCodeDropdownSource"/>.
/// Implements <seealso cref="ICustomerOrderRequestCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ETkWwN6JEeiwsev40qZGEQ")]
public partial class CustomerOrderRequestCodeDropdownRow : EnumMetadataItem<CustomerOrderRequestCode>, ICustomerOrderRequestCodeDropdownRow
{
    /// <summary>
    /// Type of customer orders that must be sent in response message.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CustomerOrderRequestCodeDropdownRow(CustomerOrderRequestCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}