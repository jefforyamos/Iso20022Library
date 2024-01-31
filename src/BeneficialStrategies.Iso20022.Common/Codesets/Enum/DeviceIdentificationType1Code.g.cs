﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeviceIdentificationType1Code.  ISO2002 ID# _Ssun0JfOEeuqNYk2TG3bTg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of device identification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ssun0JfOEeuqNYk2TG3bTg")]
[Description(@"Type of device identification.")]
[DerivedFrom(typeof(DeviceIdentificationTypeCode))]
public enum DeviceIdentificationType1Code
{
    /// <summary>
    /// International Mobile Equipment Identity.
    /// Encoded/decoded by serializers as "IMEI".
    /// </summary>
    [EnumMember(Value = "IMEI")]
    [IsoId("_XS0CIZfOEeuqNYk2TG3bTg")]
    [Description(@"International Mobile Equipment Identity.")]
    IMEI = DeviceIdentificationTypeCode.IMEI, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other nationally assigned code.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_XaxrUZfOEeuqNYk2TG3bTg")]
    [Description(@"Other nationally assigned code.")]
    OtherNational = DeviceIdentificationTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other privately assigned code.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_X8TrEZfOEeuqNYk2TG3bTg")]
    [Description(@"Other privately assigned code.")]
    OtherPrivate = DeviceIdentificationTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Secure element ID.
    /// Encoded/decoded by serializers as "SEID".
    /// </summary>
    [EnumMember(Value = "SEID")]
    [IsoId("_X9ZQMZfOEeuqNYk2TG3bTg")]
    [Description(@"Secure element ID.")]
    SecureElementIdentification = DeviceIdentificationTypeCode.SecureElementIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device serial number.
    /// Encoded/decoded by serializers as "SENU".
    /// </summary>
    [EnumMember(Value = "SENU")]
    [IsoId("_X-KsQZfOEeuqNYk2TG3bTg")]
    [Description(@"Device serial number.")]
    SerialNumber = DeviceIdentificationTypeCode.SerialNumber, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeviceIdentificationType1CodeMetadataExtensions
{
    private static readonly DeviceIdentificationType1CodeDropdownSource _dropdownSource = new DeviceIdentificationType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeviceIdentificationType1CodeDropdownRow GetMetadata(this DeviceIdentificationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


