﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for QRCodeErrorCorrection1Code.  ISO2002 ID# _LwMBINubEeiB5uLfkg9ZJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Error Correction mode of Quick Response Code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LwMBINubEeiB5uLfkg9ZJA")]
[Description(@"Error Correction mode of Quick Response Code.")]
[DerivedFrom(typeof(QRCodeErrorCorrectionCode))]
public enum QRCodeErrorCorrection1Code
{
    /// <summary>
    /// Reed-Solomon error correction 15%
    /// Encoded/decoded by serializers as "M015".
    /// </summary>
    [EnumMember(Value = "M015")]
    [IsoId("_EgtQwdudEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction 15%")]
    ErrorCorrection15Percent = QRCodeErrorCorrectionCode.ErrorCorrection15Percent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reed-Solomon error correction 25%
    /// Encoded/decoded by serializers as "Q025".
    /// </summary>
    [EnumMember(Value = "Q025")]
    [IsoId("_Ek7pcdudEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction 25%")]
    ErrorCorrection25Percent = QRCodeErrorCorrectionCode.ErrorCorrection25Percent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reed-Solomon error correction 30%
    /// Encoded/decoded by serializers as "H030".
    /// </summary>
    [EnumMember(Value = "H030")]
    [IsoId("_Eo48YdudEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction 30%")]
    ErrorCorrection30Percent = QRCodeErrorCorrectionCode.ErrorCorrection30Percent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reed-Solomon error correction  7%
    /// Encoded/decoded by serializers as "L007".
    /// </summary>
    [EnumMember(Value = "L007")]
    [IsoId("_Es55sdudEeiB5uLfkg9ZJA")]
    [Description(@"Reed-Solomon error correction  7%")]
    ErrorCorrection7Percent = QRCodeErrorCorrectionCode.ErrorCorrection7Percent, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class QRCodeErrorCorrection1CodeMetadataExtensions
{
    private static readonly QRCodeErrorCorrection1CodeDropdownSource _dropdownSource = new QRCodeErrorCorrection1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IQRCodeErrorCorrection1CodeDropdownRow GetMetadata(this QRCodeErrorCorrection1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


