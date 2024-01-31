﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CustomerAssignerCode.  ISO2002 ID# _Q2RBIFyxEeeve7Je9cXtkQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Party in charge of assigning the identification of the customer.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICustomerAssignerCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Q2RBIFyxEeeve7Je9cXtkQ")]
public partial class CustomerAssignerCodeDropdownSource : EnumMetadataManager<CustomerAssignerCode,ICustomerAssignerCodeDropdownRow,CustomerAssignerCodeDropdownRow>
{
    public CustomerAssignerCodeDropdownSource()
        : base( (enumValue, memberInfo) => new CustomerAssignerCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
