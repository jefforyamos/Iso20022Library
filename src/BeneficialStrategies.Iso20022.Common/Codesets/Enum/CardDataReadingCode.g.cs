﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CardDataReadingCode.  ISO2002 ID# _TWF24QEcEeCQm6a_G2yO_w_-992719908.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of reading of the card data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TWF24QEcEeCQm6a_G2yO_w_-992719908")]
[Description(@"Type of reading of the card data.")]
[Derivations(typeof(CardDataReading10Code),typeof(CardDataReading4Code),typeof(CardDataReading9Code),typeof(CardDataReading5Code),typeof(CardDataReading6Code),typeof(CardDataReading1Code),typeof(CardDataReading8Code),typeof(CardDataReading2Code),typeof(CardDataReading3Code),typeof(CardDataWriting1Code),typeof(CardDataReading7Code))]
public enum CardDataReadingCode
{
    /// <summary>
    /// Tag reading capabilities (RFID, etc.).
    /// Encoded/decoded by serializers as "TAGC".
    /// </summary>
    [EnumMember(Value = "TAGC")]
    [IsoId("_TWF24gEcEeCQm6a_G2yO_w_-1811496600")]
    [Description(@"Tag reading capabilities (RFID, etc.).")]
    Tag,
    
    /// <summary>
    /// Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_TWF24wEcEeCQm6a_G2yO_w_989234015")]
    [Description(@"Keyboard entry or OCR reading of embossing or printed data, either at time of transaction or after the event.")]
    Physical,
    
    /// <summary>
    /// Bar code.
    /// Encoded/decoded by serializers as "BRCD".
    /// </summary>
    [EnumMember(Value = "BRCD")]
    [IsoId("_TWF25AEcEeCQm6a_G2yO_w_1206282710")]
    [Description(@"Bar code.")]
    BarCode,
    
    /// <summary>
    /// Magnetic stripe.
    /// Encoded/decoded by serializers as "MGST".
    /// </summary>
    [EnumMember(Value = "MGST")]
    [IsoId("_TWF25QEcEeCQm6a_G2yO_w_-996765754")]
    [Description(@"Magnetic stripe.")]
    MagneticStripe,
    
    /// <summary>
    /// ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.
    /// Encoded/decoded by serializers as "CICC".
    /// </summary>
    [EnumMember(Value = "CICC")]
    [IsoId("_TWF25gEcEeCQm6a_G2yO_w_-1007864531")]
    [Description(@"ICC (Integrated Circuit Card) with contact containing software applications conform to ISO 7816.")]
    ICC,
    
    /// <summary>
    /// Account data on file.
    /// Encoded/decoded by serializers as "DFLE".
    /// </summary>
    [EnumMember(Value = "DFLE")]
    [IsoId("_TWF25wEcEeCQm6a_G2yO_w_1277145907")]
    [Description(@"Account data on file.")]
    AccountData,
    
    /// <summary>
    /// Contactless proximity reader.
    /// Encoded/decoded by serializers as "CTLS".
    /// </summary>
    [EnumMember(Value = "CTLS")]
    [IsoId("_TWF26AEcEeCQm6a_G2yO_w_1731233176")]
    [Description(@"Contactless proximity reader.")]
    ProximityReader,
    
    /// <summary>
    /// Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).
    /// Encoded/decoded by serializers as "ECTL".
    /// </summary>
    [EnumMember(Value = "ECTL")]
    [IsoId("_TWF26QEcEeCQm6a_G2yO_w_-1911037779")]
    [Description(@"Contactless proximity reader, with application conform to the standard EMV (standard initiated by Europay, Mastercard and Visa).")]
    EMVProximityReader,
    
    /// <summary>
    /// Card information are stored on a file.
    /// Encoded/decoded by serializers as "CDFL".
    /// </summary>
    [EnumMember(Value = "CDFL")]
    [IsoId("_ojDi0HrwEeSz_of_1TY14A")]
    [Description(@"Card information are stored on a file.")]
    CardOnFile,
    
    /// <summary>
    /// Unknown card reading capability.
    /// Encoded/decoded by serializers as "UNKW".
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_s8wG8HrwEeSz_of_1TY14A")]
    [Description(@"Unknown card reading capability.")]
    Unknown,
    
    /// <summary>
    /// Synchronous ICC - (Integrated Circuit Card) with contact.
    /// Encoded/decoded by serializers as "SICC".
    /// </summary>
    [EnumMember(Value = "SICC")]
    [IsoId("_TMi9cNkIEeiojJsa6FYyew")]
    [Description(@"Synchronous ICC - (Integrated Circuit Card) with contact.")]
    SynchronousIntegratedCircuitCard,
    
    /// <summary>
    /// ICC contact capability
    /// Encoded/decoded by serializers as "ICCY".
    /// </summary>
    [EnumMember(Value = "ICCY")]
    [IsoId("_JxABK3x8EemHsOqJOzMVfg")]
    [Description(@"ICC contact capability")]
    ICCContact,
    
    /// <summary>
    /// ICC contactless proximity
    /// Encoded/decoded by serializers as "ICPY".
    /// </summary>
    [EnumMember(Value = "ICPY")]
    [IsoId("_JxABLHx8EemHsOqJOzMVfg")]
    [Description(@"ICC contactless proximity")]
    ICCProximity,
    
    /// <summary>
    /// Recognition of magnetic ink characters
    /// Encoded/decoded by serializers as "MICR".
    /// </summary>
    [EnumMember(Value = "MICR")]
    [IsoId("_JxABLXx8EemHsOqJOzMVfg")]
    [Description(@"Recognition of magnetic ink characters")]
    MagneticInkCharacterRecognition,
    
    /// <summary>
    /// Manual, no terminal used.
    /// Encoded/decoded by serializers as "MLEY".
    /// </summary>
    [EnumMember(Value = "MLEY")]
    [IsoId("_JxABLnx8EemHsOqJOzMVfg")]
    [Description(@"Manual, no terminal used.")]
    ManualEntry,
    
    /// <summary>
    /// Magstripe image contactless proximity
    /// Encoded/decoded by serializers as "MSIP".
    /// </summary>
    [EnumMember(Value = "MSIP")]
    [IsoId("_JxABL3x8EemHsOqJOzMVfg")]
    [Description(@"Magstripe image contactless proximity")]
    MSIProximity,
    
    /// <summary>
    /// OCR either at time of transaction or after the event.
    /// Encoded/decoded by serializers as "OCRR".
    /// </summary>
    [EnumMember(Value = "OCRR")]
    [IsoId("_JxABMHx8EemHsOqJOzMVfg")]
    [Description(@"OCR either at time of transaction or after the event.")]
    OpticalCharacterRecognition,
    
    /// <summary>
    /// Optical coded reading capabilities (e.g. barcode, QR code, etc.)
    /// Encoded/decoded by serializers as "OPTC".
    /// </summary>
    [EnumMember(Value = "OPTC")]
    [IsoId("_JxABMXx8EemHsOqJOzMVfg")]
    [Description(@"Optical coded reading capabilities (e.g. barcode, QR code, etc.)")]
    OpticalCode,
    
    /// <summary>
    /// Other national capability type assigned at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_JxABMnx8EemHsOqJOzMVfg")]
    [Description(@"Other national capability type assigned at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other card reading capability assigned on a private basis.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_JxABM3x8EemHsOqJOzMVfg")]
    [Description(@"Other card reading capability assigned on a private basis.")]
    OtherPrivate,
    
    /// <summary>
    /// Radio Frequency Identification tag capabilities.
    /// Encoded/decoded by serializers as "RFID".
    /// </summary>
    [EnumMember(Value = "RFID")]
    [IsoId("_JxABNHx8EemHsOqJOzMVfg")]
    [Description(@"Radio Frequency Identification tag capabilities.")]
    RFIDTag,
    
    /// <summary>
    /// Unspecified capability.
    /// Encoded/decoded by serializers as "UNSP".
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_JxABNXx8EemHsOqJOzMVfg")]
    [Description(@"Unspecified capability.")]
    Unspecified,
    
    /// <summary>
    /// Key entered.
    /// Encoded/decoded by serializers as "KEEN".
    /// </summary>
    [EnumMember(Value = "KEEN")]
    [IsoId("_MeKSkOm3EemNVKPwszFC-A")]
    [Description(@"Key entered.")]
    KeyEntered,
    
    /// <summary>
    /// Quick response code.
    /// Encoded/decoded by serializers as "QRCD".
    /// </summary>
    [EnumMember(Value = "QRCD")]
    [IsoId("_iG5MwAxtEeqdx6buGpCCQw")]
    [Description(@"Quick response code.")]
    QRCode,
    
    /// <summary>
    /// Card details captured via camera.
    /// Encoded/decoded by serializers as "CAMR".
    /// </summary>
    [EnumMember(Value = "CAMR")]
    [IsoId("_rDxKYJleEeu76rs9yGlfEg")]
    [Description(@"Card details captured via camera.")]
    Camera,
    
    /// <summary>
    /// Card details were obtained via a mobile banking application.
    /// Encoded/decoded by serializers as "MBNK".
    /// </summary>
    [EnumMember(Value = "MBNK")]
    [IsoId("_n9xOwMmuEeuF1f85xf6dbg")]
    [Description(@"Card details were obtained via a mobile banking application.")]
    MobileBankingApplication,
    
    /// <summary>
    /// Card details were obtained via a token.
    /// Encoded/decoded by serializers as "TOKN".
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_FyNH4MmvEeuF1f85xf6dbg")]
    [Description(@"Card details were obtained via a token.")]
    Token,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CardDataReadingCodeMetadataExtensions
{
    private static readonly CardDataReadingCodeDropdownSource _dropdownSource = new CardDataReadingCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICardDataReadingCodeDropdownRow GetMetadata(this CardDataReadingCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


