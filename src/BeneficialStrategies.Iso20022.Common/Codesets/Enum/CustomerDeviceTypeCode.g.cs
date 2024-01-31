﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CustomerDeviceTypeCode.  ISO2002 ID# _Q1arsEesEee9r7QjOdsbFw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of customer device used for a card payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Q1arsEesEee9r7QjOdsbFw")]
[Description(@"Type of customer device used for a card payment transaction.")]
[Derivations(typeof(CustomerDeviceType1Code),typeof(CustomerDeviceType2Code))]
public enum CustomerDeviceTypeCode
{
    /// <summary>
    /// Secure card reader attached to the customer device
    /// Encoded/decoded by serializers as "SECR".
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_YSJjAEesEee9r7QjOdsbFw")]
    [Description(@"Secure card reader attached to the customer device")]
    SecureCardReader,
    
    /// <summary>
    /// Non-secure card reader attached to the customer device.
    /// Encoded/decoded by serializers as "NSCR".
    /// </summary>
    [EnumMember(Value = "NSCR")]
    [IsoId("_e-35sEesEee9r7QjOdsbFw")]
    [Description(@"Non-secure card reader attached to the customer device.")]
    NonSecureCardReader,
    
    /// <summary>
    /// Mobile phone
    /// Encoded/decoded by serializers as "MOBL".
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_kG6xkEesEee9r7QjOdsbFw")]
    [Description(@"Mobile phone")]
    Mobile,
    
    /// <summary>
    /// Tablet
    /// Encoded/decoded by serializers as "TBLT".
    /// </summary>
    [EnumMember(Value = "TBLT")]
    [IsoId("_nML5YEesEee9r7QjOdsbFw")]
    [Description(@"Tablet")]
    Tablet,
    
    /// <summary>
    /// Personal computer
    /// Encoded/decoded by serializers as "PECR".
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_rk-ekEesEee9r7QjOdsbFw")]
    [Description(@"Personal computer")]
    PersonalComputer,
    
    /// <summary>
    /// Other device defined at national level
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_yf-h0EesEee9r7QjOdsbFw")]
    [Description(@"Other device defined at national level")]
    OtherNational,
    
    /// <summary>
    /// Other device defined in a private way.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_4LcP0EesEee9r7QjOdsbFw")]
    [Description(@"Other device defined in a private way.")]
    OtherPrivate,
    
    /// <summary>
    /// Wearable device.
    /// Encoded/decoded by serializers as "WRBL".
    /// </summary>
    [EnumMember(Value = "WRBL")]
    [IsoId("_X8VvAJfIEeuqNYk2TG3bTg")]
    [Description(@"Wearable device.")]
    Wearable,
    
    /// <summary>
    /// Vehicle.
    /// Encoded/decoded by serializers as "VHCL".
    /// </summary>
    [EnumMember(Value = "VHCL")]
    [IsoId("_jNyOEJfIEeuqNYk2TG3bTg")]
    [Description(@"Vehicle.")]
    Vehicle,
    
    /// <summary>
    /// Embedded in a device.
    /// Encoded/decoded by serializers as "EMBD".
    /// </summary>
    [EnumMember(Value = "EMBD")]
    [IsoId("_sYPygJfIEeuqNYk2TG3bTg")]
    [Description(@"Embedded in a device.")]
    Embedded,
    
    /// <summary>
    /// Key Fob
    /// Encoded/decoded by serializers as "KFOB".
    /// </summary>
    [EnumMember(Value = "KFOB")]
    [IsoId("_waLSYCbMEeyhZIgCcGlTyA")]
    [Description(@"Key Fob")]
    KeyFob,
    
    /// <summary>
    /// Jewellery
    /// Encoded/decoded by serializers as "JEWL".
    /// </summary>
    [EnumMember(Value = "JEWL")]
    [IsoId("_C5CaYCbNEeyhZIgCcGlTyA")]
    [Description(@"Jewellery")]
    Jewellery,
    
    /// <summary>
    /// Sticker
    /// Encoded/decoded by serializers as "STIC".
    /// </summary>
    [EnumMember(Value = "STIC")]
    [IsoId("_GzW64CbNEeyhZIgCcGlTyA")]
    [Description(@"Sticker")]
    Sticker,
    
    /// <summary>
    /// Gaming Device
    /// Encoded/decoded by serializers as "GAMB".
    /// </summary>
    [EnumMember(Value = "GAMB")]
    [IsoId("_JRYcgCbNEeyhZIgCcGlTyA")]
    [Description(@"Gaming Device")]
    GamingDevice,
    
    /// <summary>
    /// Watch
    /// Encoded/decoded by serializers as "WATC".
    /// </summary>
    [EnumMember(Value = "WATC")]
    [IsoId("_MH0eICbNEeyhZIgCcGlTyA")]
    [Description(@"Watch")]
    Watch,
    
    /// <summary>
    /// Device type unknown
    /// Encoded/decoded by serializers as "UNKW".
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_Qai8wEQHEeyANrrBvBlqVg")]
    [Description(@"Device type unknown")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CustomerDeviceTypeCodeMetadataExtensions
{
    private static readonly CustomerDeviceTypeCodeDropdownSource _dropdownSource = new CustomerDeviceTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICustomerDeviceTypeCodeDropdownRow GetMetadata(this CustomerDeviceTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


