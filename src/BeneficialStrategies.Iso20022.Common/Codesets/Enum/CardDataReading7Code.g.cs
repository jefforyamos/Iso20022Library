﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardDataReading7Code.  ISO2002 ID# _CHFy4UeoEee9r7QjOdsbFw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Card  reading capabilities of the terminal performing the transaction. 
///  ISO 8583:93 bit 22-2, ISO 8583:2003 bit 27-1
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CHFy4UeoEee9r7QjOdsbFw")]
[Description(@"Card  reading capabilities of the terminal performing the transaction. | ISO 8583:93 bit 22-2, ISO 8583:2003 bit 27-1")]
[DerivedFrom(typeof(CardDataReadingCode))]
public enum CardDataReading7Code
{
    /// <summary>
    /// Card information are stored on a file.
    /// Encoded/decoded by serializers as "CDFL".
    /// </summary>
    [EnumMember(Value = "CDFL")]
    [IsoId("_wBejIX0kEemfrNOe0zHQyg")]
    [Description(@"Card information are stored on a file.")]
    CardOnFile = CardDataReadingCode.CardOnFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ICC contactless proximity
    /// Encoded/decoded by serializers as "ICPY".
    /// </summary>
    [EnumMember(Value = "ICPY")]
    [IsoId("_wBejI30kEemfrNOe0zHQyg")]
    [Description(@"ICC contactless proximity")]
    ICCProximity = CardDataReadingCode.ICCProximity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as "MGST".
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_wBejJX0kEemfrNOe0zHQyg")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe = CardDataReadingCode.MagneticStripe, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ICC contact capability
    /// Encoded/decoded by serializers as "ICCY".
    /// </summary>
    [EnumMember(Value = "ICCY")]
    [IsoId("_wBejJ30kEemfrNOe0zHQyg")]
    [Description(@"ICC contact capability")]
    ICCContact = CardDataReadingCode.ICCContact, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Recognition of magnetic ink characters
    /// Encoded/decoded by serializers as "MICR".
    /// </summary>
    [EnumMember(Value = "MICR")]
    [IsoId("_wBejKX0kEemfrNOe0zHQyg")]
    [Description(@"Recognition of magnetic ink characters")]
    MagneticInkCharacterRecognition = CardDataReadingCode.MagneticInkCharacterRecognition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Manual, no terminal used.
    /// Encoded/decoded by serializers as "MLEY".
    /// </summary>
    [EnumMember(Value = "MLEY")]
    [IsoId("_wBejK30kEemfrNOe0zHQyg")]
    [Description(@"Manual, no terminal used.")]
    ManualEntry = CardDataReadingCode.ManualEntry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// OCR either at time of transaction or after the event.
    /// Encoded/decoded by serializers as "OCRR".
    /// </summary>
    [EnumMember(Value = "OCRR")]
    [IsoId("_wBejLX0kEemfrNOe0zHQyg")]
    [Description(@"OCR either at time of transaction or after the event.")]
    OpticalCharacterRecognition = CardDataReadingCode.OpticalCharacterRecognition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Magstripe image contactless proximity
    /// Encoded/decoded by serializers as "MSIP".
    /// </summary>
    [EnumMember(Value = "MSIP")]
    [IsoId("_wBejL30kEemfrNOe0zHQyg")]
    [Description(@"Magstripe image contactless proximity")]
    MSIProximity = CardDataReadingCode.MSIProximity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Optical coded reading capabilities (e.g. barcode, QR code, etc.)
    /// Encoded/decoded by serializers as "OPTC".
    /// </summary>
    [EnumMember(Value = "OPTC")]
    [IsoId("_wBejMX0kEemfrNOe0zHQyg")]
    [Description(@"Optical coded reading capabilities (e.g. barcode, QR code, etc.)")]
    OpticalCode = CardDataReadingCode.OpticalCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other national capability type assigned at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_wBejM30kEemfrNOe0zHQyg")]
    [Description(@"Other national capability type assigned at national level.")]
    OtherNational = CardDataReadingCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Radio Frequency Identification tag capabilities.
    /// Encoded/decoded by serializers as "RFID".
    /// </summary>
    [EnumMember(Value = "RFID")]
    [IsoId("_wBejNX0kEemfrNOe0zHQyg")]
    [Description(@"Radio Frequency Identification tag capabilities.")]
    RFIDTag = CardDataReadingCode.RFIDTag, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unspecified capability.
    /// Encoded/decoded by serializers as "UNSP".
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_wBejN30kEemfrNOe0zHQyg")]
    [Description(@"Unspecified capability.")]
    Unspecified = CardDataReadingCode.Unspecified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other card reading capability assigned on a private basis.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_wBejOX0kEemfrNOe0zHQyg")]
    [Description(@"Other card reading capability assigned on a private basis.")]
    OtherPrivate = CardDataReadingCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key entered.
    /// Encoded/decoded by serializers as "KEEN".
    /// </summary>
    [EnumMember(Value = "KEEN")]
    [IsoId("_TZ9AAem3EemNVKPwszFC-A")]
    [Description(@"Key entered.")]
    KeyEntered = CardDataReadingCode.KeyEntered, // same ordinal as derivation source for type conversions
    
}
