﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardDataReading9Code.  ISO2002 ID# _ApKlgJlfEeu76rs9yGlfEg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method used to obtain card payment information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ApKlgJlfEeu76rs9yGlfEg")]
[Description(@"Method used to obtain card payment information.")]
[DerivedFrom(typeof(CardDataReadingCode))]
public enum CardDataReading9Code
{
    /// <summary>
    /// Unknown card reading capability.
    /// Encoded/decoded by serializers as "Unknown".
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_JDP14ZlfEeu76rs9yGlfEg")]
    [Description(@"Unknown card reading capability.")]
    Unknown,
    
    /// <summary>
    /// Other national capability type assigned at national level.
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_JtshEZlfEeu76rs9yGlfEg")]
    [Description(@"Other national capability type assigned at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other card reading capability assigned on a private basis.
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_J0hh0ZlfEeu76rs9yGlfEg")]
    [Description(@"Other card reading capability assigned on a private basis.")]
    OtherPrivate,
    
    /// <summary>
    /// Card details captured via camera.
    /// Encoded/decoded by serializers as "Camera".
    /// </summary>
    [EnumMember(Value = "CAMR")]
    [IsoId("_N2p6gZlfEeu76rs9yGlfEg")]
    [Description(@"Card details captured via camera.")]
    Camera,
    
    /// <summary>
    /// Key entered.
    /// Encoded/decoded by serializers as "KeyEntered".
    /// </summary>
    [EnumMember(Value = "KEEN")]
    [IsoId("_ujzGIZlfEeu76rs9yGlfEg")]
    [Description(@"Key entered.")]
    KeyEntered,
    
    /// <summary>
    /// ICC contactless proximity
    /// Encoded/decoded by serializers as "ICCProximity".
    /// </summary>
    [EnumMember(Value = "ICPY")]
    [IsoId("_05JGUazhEeurLutE1vUWxQ")]
    [Description(@"ICC contactless proximity")]
    ICCProximity,
    
    /// <summary>
    /// Optical coded reading capabilities (e.g. barcode, QR code, etc.)
    /// Encoded/decoded by serializers as "OpticalCode".
    /// </summary>
    [EnumMember(Value = "OPTC")]
    [IsoId("_iyilMa7BEeuhTp7lI6XAzA")]
    [Description(@"Optical coded reading capabilities (e.g. barcode, QR code, etc.)")]
    OpticalCode,
    
    /// <summary>
    /// Card information are stored on a file.
    /// Encoded/decoded by serializers as "CardOnFile".
    /// </summary>
    [EnumMember(Value = "CDFL")]
    [IsoId("_b9Nm8cmuEeuF1f85xf6dbg")]
    [Description(@"Card information are stored on a file.")]
    CardOnFile,
    
    /// <summary>
    /// Card details were obtained via a mobile banking application.
    /// Encoded/decoded by serializers as "MobileBankingApplication".
    /// </summary>
    [EnumMember(Value = "MBNK")]
    [IsoId("_4QIqAcmuEeuF1f85xf6dbg")]
    [Description(@"Card details were obtained via a mobile banking application.")]
    MobileBankingApplication,
    
    /// <summary>
    /// Card details were obtained via a token.
    /// Encoded/decoded by serializers as "Token".
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_OuQc4cmvEeuF1f85xf6dbg")]
    [Description(@"Card details were obtained via a token.")]
    Token,
    
    /// <summary>
    /// ICC contact capability
    /// Encoded/decoded by serializers as "ICCContact".
    /// </summary>
    [EnumMember(Value = "ICCY")]
    [IsoId("_XJ0T8cmvEeuF1f85xf6dbg")]
    [Description(@"ICC contact capability")]
    ICCContact,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardDataReading9CodeMetadataExtensions
{
    private static readonly CardDataReading9CodeDropdownSource _dropdownSource = new CardDataReading9CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardDataReading9CodeDropdownRow GetMetadata(this CardDataReading9Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


