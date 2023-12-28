﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardDataReading5Code.  ISO2002 ID# _j7nYMY0REeWRYffwL7E13A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of reading of the card data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_j7nYMY0REeWRYffwL7E13A")]
[Description(@"Type of reading of the card data.")]
[DerivedFrom(typeof(CardDataReadingCode))]
public enum CardDataReading5Code
{
    /// <summary>
    /// Tag reading capabilities (RFID, etc.).
    /// Encoded/decoded by serializers as "Tag".
    /// </summary>
    [EnumMember(Value = "TAGC")]
    [IsoId("_kGMQgY0REeWRYffwL7E13A")]
    [Description(@"Tag reading capabilities (RFID, etc.).")]
    Tag,
    
    /// <summary>
    /// Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event.
    /// Encoded/decoded by serializers as "Physical".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_kGMQg40REeWRYffwL7E13A")]
    [Description(@"Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event.")]
    Physical,
    
    /// <summary>
    /// Bar code.
    /// Encoded/decoded by serializers as "BarCode".
    /// </summary>
    [EnumMember(Value = "BRCD")]
    [IsoId("_kGMQhY0REeWRYffwL7E13A")]
    [Description(@"Bar code.")]
    BarCode,
    
    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as "MagneticStripe".
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_kGMQh40REeWRYffwL7E13A")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe,
    
    /// <summary>
    /// ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.
    /// Encoded/decoded by serializers as "ICC".
    /// </summary>
    [EnumMember(Value = "CICC")]
    [IsoId("_kGMQiY0REeWRYffwL7E13A")]
    [Description(@"ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.")]
    ICC,
    
    /// <summary>
    /// Account data on file.
    /// Encoded/decoded by serializers as "AccountData".
    /// </summary>
    [EnumMember(Value = "DFLE")]
    [IsoId("_kGMQi40REeWRYffwL7E13A")]
    [Description(@"Account data on file.")]
    AccountData,
    
    /// <summary>
    /// Contactless proximity reader.
    /// Encoded/decoded by serializers as "ProximityReader".
    /// </summary>
    [EnumMember(Value = "CTLS")]
    [IsoId("_kGMQjY0REeWRYffwL7E13A")]
    [Description(@"Contactless proximity reader.")]
    ProximityReader,
    
    /// <summary>
    /// Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).
    /// Encoded/decoded by serializers as "EMVProximityReader".
    /// </summary>
    [EnumMember(Value = "ECTL")]
    [IsoId("_kGMQj40REeWRYffwL7E13A")]
    [Description(@"Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).")]
    EMVProximityReader,
    
    /// <summary>
    /// Card information are stored on a file.
    /// Encoded/decoded by serializers as "CardOnFile".
    /// </summary>
    [EnumMember(Value = "CDFL")]
    [IsoId("_n7UH8Y0REeWRYffwL7E13A")]
    [Description(@"Card information are stored on a file.")]
    CardOnFile,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardDataReading5CodeMetadataExtensions
{
    private static readonly CardDataReading5CodeDropdownSource _dropdownSource = new CardDataReading5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardDataReading5CodeDropdownRow GetMetadata(this CardDataReading5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


