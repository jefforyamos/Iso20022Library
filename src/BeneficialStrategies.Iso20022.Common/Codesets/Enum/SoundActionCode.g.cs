﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SoundActionCode.  ISO2002 ID# _WrnSAN6-Eeiwsev40qZGEQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of action to perform on the sound.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WrnSAN6-Eeiwsev40qZGEQ")]
[Description(@"Type of action to perform on the sound.")]
[Derivations(typeof(SoundAction1Code))]
public enum SoundActionCode
{
    /// <summary>
    /// Start the sound as specified in the message.
    /// Encoded/decoded by serializers as "STAS".
    /// </summary>
    [EnumMember(Value = "STAS")]
    [IsoId("_fGWpsN6-Eeiwsev40qZGEQ")]
    [Description(@"Start the sound as specified in the message.")]
    StartSound,
    
    /// <summary>
    /// Stop the sound in progress.
    /// Encoded/decoded by serializers as "STOS".
    /// </summary>
    [EnumMember(Value = "STOS")]
    [IsoId("_hr_PMN6-Eeiwsev40qZGEQ")]
    [Description(@"Stop the sound in progress.")]
    StopSound,
    
    /// <summary>
    /// Set the default volume of sounds.
    /// Encoded/decoded by serializers as "DVOL".
    /// </summary>
    [EnumMember(Value = "DVOL")]
    [IsoId("_kdmbMN6-Eeiwsev40qZGEQ")]
    [Description(@"Set the default volume of sounds.")]
    SetDefaultVolume,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SoundActionCodeMetadataExtensions
{
    private static readonly SoundActionCodeDropdownSource _dropdownSource = new SoundActionCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISoundActionCodeDropdownRow GetMetadata(this SoundActionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


