﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CustomerHandlingInstructions1Code.  ISO2002 ID# _bUhmSdp-Ed-ak6NoX_4Aeg_-1415296832.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Firms that are taking in orders manually but routing for execution electronically and for reporting to OATS must capture the client's handling instructions.This is intended for compliance reporting only ( OATS Phase III regulatory requirement).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICustomerHandlingInstructions1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bUhmSdp-Ed-ak6NoX_4Aeg_-1415296832")]
public partial class CustomerHandlingInstructions1CodeDropdownSource : EnumMetadataManager<CustomerHandlingInstructions1Code,ICustomerHandlingInstructions1CodeDropdownRow,CustomerHandlingInstructions1CodeDropdownRow>
{
    public CustomerHandlingInstructions1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CustomerHandlingInstructions1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
