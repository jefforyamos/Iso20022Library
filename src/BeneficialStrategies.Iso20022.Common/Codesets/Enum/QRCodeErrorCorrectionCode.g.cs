﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for QRCodeErrorCorrectionCode.  ISO2002 ID# _55g6gNuaEeiB5uLfkg9ZJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Error Correction mode of Quick Response Code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_55g6gNuaEeiB5uLfkg9ZJA")]
[Description(@"Error Correction mode of Quick Response Code.")]
[Derivations(typeof(QRCodeErrorCorrection1Code))]
public enum QRCodeErrorCorrectionCode
{
    /// <summary>
    /// Reed-Solomon error correction  7%
    /// Encoded/decoded by serializers as "L007".
    /// </summary>
    [EnumMember(Value = "L007")]
    [IsoId("_-CY0YNuaEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction  7%")]
    ErrorCorrection7Percent,
    
    /// <summary>
    /// Reed-Solomon error correction 15%
    /// Encoded/decoded by serializers as "M015".
    /// </summary>
    [EnumMember(Value = "M015")]
    [IsoId("_C9HB8NubEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction 15%")]
    ErrorCorrection15Percent,
    
    /// <summary>
    /// Reed-Solomon error correction 25%
    /// Encoded/decoded by serializers as "Q025".
    /// </summary>
    [EnumMember(Value = "Q025")]
    [IsoId("_F43BYNubEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction 25%")]
    ErrorCorrection25Percent,
    
    /// <summary>
    /// Reed-Solomon error correction 30%
    /// Encoded/decoded by serializers as "H030".
    /// </summary>
    [EnumMember(Value = "H030")]
    [IsoId("_IqPj4NubEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction 30%")]
    ErrorCorrection30Percent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class QRCodeErrorCorrectionCodeMetadataExtensions
{
    private static readonly QRCodeErrorCorrectionCodeDropdownSource _dropdownSource = new QRCodeErrorCorrectionCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IQRCodeErrorCorrectionCodeDropdownRow GetMetadata(this QRCodeErrorCorrectionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


