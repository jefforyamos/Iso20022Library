﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CustomerDeviceType2Code.  ISO2002 ID# _GYK4MZfJEeuqNYk2TG3bTg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of customer device.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICustomerDeviceType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_GYK4MZfJEeuqNYk2TG3bTg")]
public partial class CustomerDeviceType2CodeDropdownSource : EnumMetadataManager<CustomerDeviceType2Code,ICustomerDeviceType2CodeDropdownRow,CustomerDeviceType2CodeDropdownRow>
{
    public CustomerDeviceType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CustomerDeviceType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
