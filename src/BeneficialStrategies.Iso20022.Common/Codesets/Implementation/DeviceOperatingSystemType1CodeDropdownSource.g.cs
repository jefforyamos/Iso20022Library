﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DeviceOperatingSystemType1Code.  ISO2002 ID# _1J-XwJfREeuqNYk2TG3bTg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of operating system deployed on device.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDeviceOperatingSystemType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1J-XwJfREeuqNYk2TG3bTg")]
public partial class DeviceOperatingSystemType1CodeDropdownSource : EnumMetadataManager<DeviceOperatingSystemType1Code,IDeviceOperatingSystemType1CodeDropdownRow,DeviceOperatingSystemType1CodeDropdownRow>
{
    public DeviceOperatingSystemType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DeviceOperatingSystemType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
