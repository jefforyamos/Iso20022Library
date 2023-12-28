﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CustomerDeviceType2Code.  ISO2002 ID# _GYK4MZfJEeuqNYk2TG3bTg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of customer device.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GYK4MZfJEeuqNYk2TG3bTg")]
[Description(@"Type of customer device.")]
[DerivedFrom(typeof(CustomerDeviceTypeCode))]
public enum CustomerDeviceType2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Mobile".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GeUjgZfJEeuqNYk2TG3bTg")]
    [Description(@"??")]
    Mobile,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GeUjg5fJEeuqNYk2TG3bTg")]
    [Description(@"??")]
    OtherNational,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GeUjhZfJEeuqNYk2TG3bTg")]
    [Description(@"??")]
    OtherPrivate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PersonalComputer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GeUjh5fJEeuqNYk2TG3bTg")]
    [Description(@"??")]
    PersonalComputer,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Tablet".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GeUjiZfJEeuqNYk2TG3bTg")]
    [Description(@"??")]
    Tablet,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NonSecureCardReader".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GeUji5fJEeuqNYk2TG3bTg")]
    [Description(@"??")]
    NonSecureCardReader,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecureCardReader".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_GeUjjZfJEeuqNYk2TG3bTg")]
    [Description(@"??")]
    SecureCardReader,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Embedded".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jCjZAZfJEeuqNYk2TG3bTg")]
    [Description(@"??")]
    Embedded,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Vehicle".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jkdMMZfJEeuqNYk2TG3bTg")]
    [Description(@"??")]
    Vehicle,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Wearable".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_j6peoZfJEeuqNYk2TG3bTg")]
    [Description(@"??")]
    Wearable,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Watch".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_V800YSbNEeyhZIgCcGlTyA")]
    [Description(@"??")]
    Watch,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "GamingDevice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WCc7QSbNEeyhZIgCcGlTyA")]
    [Description(@"??")]
    GamingDevice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Jewellery".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WHQiwSbNEeyhZIgCcGlTyA")]
    [Description(@"??")]
    Jewellery,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "KeyFob".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WPLvsSbNEeyhZIgCcGlTyA")]
    [Description(@"??")]
    KeyFob,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Sticker".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WjVawSbNEeyhZIgCcGlTyA")]
    [Description(@"??")]
    Sticker,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unknown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dOHV4UQHEeyANrrBvBlqVg")]
    [Description(@"??")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CustomerDeviceType2CodeMetadataExtensions
{
    private static readonly CustomerDeviceType2CodeDropdownSource _dropdownSource = new CustomerDeviceType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICustomerDeviceType2CodeDropdownRow GetMetadata(this CustomerDeviceType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

