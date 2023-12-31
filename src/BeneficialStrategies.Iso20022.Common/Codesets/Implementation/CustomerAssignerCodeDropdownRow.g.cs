﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CustomerAssignerCode.  ISO2002 ID# _Q2RBIFyxEeeve7Je9cXtkQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Party in charge of assigning the identification of the customer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CustomerAssignerCodeDropdownSource"/>.
/// Implements <seealso cref="ICustomerAssignerCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Q2RBIFyxEeeve7Je9cXtkQ")]
public partial class CustomerAssignerCodeDropdownRow : EnumMetadataItem<CustomerAssignerCode>, ICustomerAssignerCodeDropdownRow
{
    /// <summary>
    /// Party in charge of assigning the identification of the customer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CustomerAssignerCodeDropdownRow(CustomerAssignerCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
