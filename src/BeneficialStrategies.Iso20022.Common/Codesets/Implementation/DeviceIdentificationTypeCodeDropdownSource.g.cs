﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DeviceIdentificationTypeCode.  ISO2002 ID# _KxndUJfMEeuqNYk2TG3bTg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of identification for the device.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDeviceIdentificationTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KxndUJfMEeuqNYk2TG3bTg")]
public partial class DeviceIdentificationTypeCodeDropdownSource : EnumMetadataManager<DeviceIdentificationTypeCode,IDeviceIdentificationTypeCodeDropdownRow,DeviceIdentificationTypeCodeDropdownRow>
{
    public DeviceIdentificationTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DeviceIdentificationTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}