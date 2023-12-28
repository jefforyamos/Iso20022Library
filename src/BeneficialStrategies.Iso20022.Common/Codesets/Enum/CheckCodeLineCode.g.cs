﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CheckCodeLineCode.  ISO2002 ID# _JUeaoK4EEeWL1uap3dNhCQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Format of the check code line.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JUeaoK4EEeWL1uap3dNhCQ")]
[Description(@"Format of the check code line.")]
[Derivations(typeof(CheckCodeLine1Code))]
// External derivations that should be provided by the proper interface are: 
public enum CheckCodeLineCode
{
    /// <summary>
    /// Magnetic ink character digitally encoded with 7 sticks.
    /// Encoded/decoded by serializers as "CMC7".
    /// </summary>
    [EnumMember(Value = "CMC7")]
    [IsoId("_O9mmUK4EEeWL1uap3dNhCQ")]
    [Description(@"Magnetic ink character digitally encoded with 7 sticks.")]
    CMC7,
    
    /// <summary>
    /// Magnetic ink character recognition., conform to ISO 1004.
    /// Encoded/decoded by serializers as "E13B".
    /// </summary>
    [EnumMember(Value = "E13B")]
    [IsoId("_RxecIK4EEeWL1uap3dNhCQ")]
    [Description(@"Magnetic ink character recognition., conform to ISO 1004.")]
    E13B,
    
    /// <summary>
    /// Optical character recognition font A, conform to ANSI X3.17: 1981.
    /// Encoded/decoded by serializers as "OCRA".
    /// </summary>
    [EnumMember(Value = "OCRA")]
    [IsoId("_UH3rwK4EEeWL1uap3dNhCQ")]
    [Description(@"Optical character recognition font A, conform to ANSI X3.17: 1981.")]
    OCRA,
    
    /// <summary>
    /// Optical character recognition font B, conform to ANSI X3.49: 1975.
    /// Encoded/decoded by serializers as "OCRB".
    /// </summary>
    [EnumMember(Value = "OCRB")]
    [IsoId("_Wpt9cK4EEeWL1uap3dNhCQ")]
    [Description(@"Optical character recognition font B, conform to ANSI X3.49: 1975.")]
    OCRB,
    
    /// <summary>
    /// Default optical character recognition used.
    /// Encoded/decoded by serializers as "OCRF".
    /// </summary>
    [EnumMember(Value = "OCRF")]
    [IsoId("_ZSIxMK4EEeWL1uap3dNhCQ")]
    [Description(@"Default optical character recognition used.")]
    OCRDefault,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CheckCodeLineCodeMetadataExtensions
{
    private static readonly CheckCodeLineCodeDropdownSource _dropdownSource = new CheckCodeLineCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICheckCodeLineCodeDropdownRow GetMetadata(this CheckCodeLineCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


