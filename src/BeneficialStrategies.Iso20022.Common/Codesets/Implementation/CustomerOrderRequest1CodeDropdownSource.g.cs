﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CustomerOrderRequest1Code.  ISO2002 ID# _ShkGgN6JEeiwsev40qZGEQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of customer orders that must be sent in response message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICustomerOrderRequest1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ShkGgN6JEeiwsev40qZGEQ")]
public partial class CustomerOrderRequest1CodeDropdownSource : EnumMetadataManager<CustomerOrderRequest1Code,ICustomerOrderRequest1CodeDropdownRow,CustomerOrderRequest1CodeDropdownRow>
{
    public CustomerOrderRequest1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CustomerOrderRequest1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
