﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeviceIdentificationTypeCode.  ISO2002 ID# _KxndUJfMEeuqNYk2TG3bTg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of identification for the device.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KxndUJfMEeuqNYk2TG3bTg")]
[Description(@"Type of identification for the device.")]
[Derivations(typeof(DeviceIdentificationType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum DeviceIdentificationTypeCode
{
    /// <summary>
    /// International Mobile Equipment Identity.
    /// Encoded/decoded by serializers as "IMEI".
    /// </summary>
    [EnumMember(Value = "IMEI")]
    [IsoId("_VFsVMJfMEeuqNYk2TG3bTg")]
    [Description(@"International Mobile Equipment Identity.")]
    IMEI,
    
    /// <summary>
    /// Device serial number.
    /// Encoded/decoded by serializers as "SENU".
    /// </summary>
    [EnumMember(Value = "SENU")]
    [IsoId("_mqqAwJfMEeuqNYk2TG3bTg")]
    [Description(@"Device serial number.")]
    SerialNumber,
    
    /// <summary>
    /// Secure element ID.
    /// Encoded/decoded by serializers as "SEID".
    /// </summary>
    [EnumMember(Value = "SEID")]
    [IsoId("_Fh1JQJfNEeuqNYk2TG3bTg")]
    [Description(@"Secure element ID.")]
    SecureElementIdentification,
    
    /// <summary>
    /// Other nationally assigned code.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_MVjf0JfNEeuqNYk2TG3bTg")]
    [Description(@"Other nationally assigned code.")]
    OtherNational,
    
    /// <summary>
    /// Other privately assigned code.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_YTPZ0JfNEeuqNYk2TG3bTg")]
    [Description(@"Other privately assigned code.")]
    OtherPrivate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeviceIdentificationTypeCodeMetadataExtensions
{
    private static readonly DeviceIdentificationTypeCodeDropdownSource _dropdownSource = new DeviceIdentificationTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeviceIdentificationTypeCodeDropdownRow GetMetadata(this DeviceIdentificationTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


