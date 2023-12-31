﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for QRCodeEncodingMode1Code.  ISO2002 ID# _dB7rMNuaEeiB5uLfkg9ZJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Encoding Mode of Quick Response Code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dB7rMNuaEeiB5uLfkg9ZJA")]
[Description(@"Encoding Mode of Quick Response Code.")]
[DerivedFrom(typeof(QRCodeEncodingModeCode))]
public enum QRCodeEncodingMode1Code
{
    /// <summary>
    /// Alphanumeric value provided in Barcode field.
    /// Encoded/decoded by serializers as "Alphanumeric".
    /// </summary>
    [EnumMember(Value = "ALFA")]
    [IsoId("_C2JMYdudEeiB5uLfkg9ZJA")]
    [Description(@"Alphanumeric value provided in Barcode field.")]
    Alphanumeric,
    
    /// <summary>
    /// Binary value provided in Quick Response Code Binary Value.
    /// Encoded/decoded by serializers as "Binary".
    /// </summary>
    [EnumMember(Value = "BINA")]
    [IsoId("_C6I7kdudEeiB5uLfkg9ZJA")]
    [Description(@"Binary value provided in Quick Response Code Binary Value.")]
    Binary,
    
    /// <summary>
    /// Kanji value provided in Quick Response Code Binary Value.
    /// Encoded/decoded by serializers as "Kanji".
    /// </summary>
    [EnumMember(Value = "KANJ")]
    [IsoId("_C-EZUdudEeiB5uLfkg9ZJA")]
    [Description(@"Kanji value provided in Quick Response Code Binary Value.")]
    Kanji,
    
    /// <summary>
    /// Numeric value provided in Barcode field.
    /// Encoded/decoded by serializers as "Numeric".
    /// </summary>
    [EnumMember(Value = "NUME")]
    [IsoId("_DCOgkdudEeiB5uLfkg9ZJA")]
    [Description(@"Numeric value provided in Barcode field.")]
    Numeric,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class QRCodeEncodingMode1CodeMetadataExtensions
{
    private static readonly QRCodeEncodingMode1CodeDropdownSource _dropdownSource = new QRCodeEncodingMode1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IQRCodeEncodingMode1CodeDropdownRow GetMetadata(this QRCodeEncodingMode1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


