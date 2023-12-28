﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CheckCodeLine1Code.  ISO2002 ID# _ecCDMK4EEeWL1uap3dNhCQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Format of the check code line.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ecCDMK4EEeWL1uap3dNhCQ")]
[Description(@"Format of the check code line.")]
[DerivedFrom(typeof(CheckCodeLineCode))]
public enum CheckCodeLine1Code
{
    /// <summary>
    /// Magnetic ink character digitally encoded with 7 sticks.
    /// Encoded/decoded by serializers as "CMC7".
    /// </summary>
    [EnumMember(Value = "CMC7")]
    [IsoId("_jJnMoa4EEeWL1uap3dNhCQ")]
    [Description(@"Magnetic ink character digitally encoded with 7 sticks.")]
    CMC7,
    
    /// <summary>
    /// Magnetic ink character recognition., conform to ISO 1004.
    /// Encoded/decoded by serializers as "E13B".
    /// </summary>
    [EnumMember(Value = "E13B")]
    [IsoId("_jRgkY64EEeWL1uap3dNhCQ")]
    [Description(@"Magnetic ink character recognition., conform to ISO 1004.")]
    E13B,
    
    /// <summary>
    /// Optical character recognition font A, conform to ANSI X3.17: 1981.
    /// Encoded/decoded by serializers as "OCRA".
    /// </summary>
    [EnumMember(Value = "OCRA")]
    [IsoId("_jTceEa4EEeWL1uap3dNhCQ")]
    [Description(@"Optical character recognition font A, conform to ANSI X3.17: 1981.")]
    OCRA,
    
    /// <summary>
    /// Optical character recognition font B, conform to ANSI X3.49: 1975.
    /// Encoded/decoded by serializers as "OCRB".
    /// </summary>
    [EnumMember(Value = "OCRB")]
    [IsoId("_jYqVQa4EEeWL1uap3dNhCQ")]
    [Description(@"Optical character recognition font B, conform to ANSI X3.49: 1975.")]
    OCRB,
    
    /// <summary>
    /// Default optical character recognition used.
    /// Encoded/decoded by serializers as "OCRDefault".
    /// </summary>
    [EnumMember(Value = "OCRF")]
    [IsoId("_jjGDo64EEeWL1uap3dNhCQ")]
    [Description(@"Default optical character recognition used.")]
    OCRDefault,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CheckCodeLine1CodeMetadataExtensions
{
    private static readonly CheckCodeLine1CodeDropdownSource _dropdownSource = new CheckCodeLine1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICheckCodeLine1CodeDropdownRow GetMetadata(this CheckCodeLine1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


