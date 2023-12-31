﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CustomerOrderRequestCode.  ISO2002 ID# _ETkWwN6JEeiwsev40qZGEQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of customer orders that must be sent in response message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICustomerOrderRequestCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ETkWwN6JEeiwsev40qZGEQ")]
public partial class CustomerOrderRequestCodeDropdownSource : EnumMetadataManager<CustomerOrderRequestCode,ICustomerOrderRequestCodeDropdownRow,CustomerOrderRequestCodeDropdownRow>
{
    public CustomerOrderRequestCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CustomerOrderRequestCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
