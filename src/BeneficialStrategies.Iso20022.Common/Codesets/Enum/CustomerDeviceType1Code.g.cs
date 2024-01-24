﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CustomerDeviceType1Code.  ISO2002 ID# _IQUBoEetEee9r7QjOdsbFw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of customer device.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IQUBoEetEee9r7QjOdsbFw")]
[Description(@"Type of customer device.")]
[DerivedFrom(typeof(CustomerDeviceTypeCode))]
public enum CustomerDeviceType1Code
{
    /// <summary>
    /// Mobile phone
    /// Encoded/decoded by serializers as "MOBL".
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_LGwDQUetEee9r7QjOdsbFw")]
    [Description(@"Mobile phone")]
    Mobile = CustomerDeviceTypeCode.Mobile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other device defined at national level
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_LfTtMketEee9r7QjOdsbFw")]
    [Description(@"Other device defined at national level")]
    OtherNational = CustomerDeviceTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other device defined in a private way.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_LtiWcketEee9r7QjOdsbFw")]
    [Description(@"Other device defined in a private way.")]
    OtherPrivate = CustomerDeviceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Personal computer
    /// Encoded/decoded by serializers as "PECR".
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_L6nwMketEee9r7QjOdsbFw")]
    [Description(@"Personal computer")]
    PersonalComputer = CustomerDeviceTypeCode.PersonalComputer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tablet
    /// Encoded/decoded by serializers as "TBLT".
    /// </summary>
    [EnumMember(Value = "TBLT")]
    [IsoId("_MSSpUketEee9r7QjOdsbFw")]
    [Description(@"Tablet")]
    Tablet = CustomerDeviceTypeCode.Tablet, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Non-secure card reader attached to the customer device.
    /// Encoded/decoded by serializers as "NSCR".
    /// </summary>
    [EnumMember(Value = "NSCR")]
    [IsoId("_MieKIS7TEemIy6A-26wnAg")]
    [Description(@"Non-secure card reader attached to the customer device.")]
    NonSecureCardReader = CustomerDeviceTypeCode.NonSecureCardReader, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Secure card reader attached to the customer device
    /// Encoded/decoded by serializers as "SECR".
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_Mw-gMS7TEemIy6A-26wnAg")]
    [Description(@"Secure card reader attached to the customer device")]
    SecureCardReader = CustomerDeviceTypeCode.SecureCardReader, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CustomerDeviceType1CodeMetadataExtensions
{
    private static readonly CustomerDeviceType1CodeDropdownSource _dropdownSource = new CustomerDeviceType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICustomerDeviceType1CodeDropdownRow GetMetadata(this CustomerDeviceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


