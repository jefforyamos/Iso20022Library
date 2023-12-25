﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InitialPhysicalFormCode.  ISO2002 ID# _hblKmGliEeGaMcKyqKNRfQ_420935209.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the physical form of the securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hblKmGliEeGaMcKyqKNRfQ_420935209")]
[Description(@"Indicates the physical form of the securities.")]
public enum InitialPhysicalFormCode
{
    /// <summary>
    /// Initial Physical Form is GT.
    /// </summary>
    [EnumMember(Value = "GTGT")]
    [IsoId("_hblKmWliEeGaMcKyqKNRfQ_-939155429")]
    [Description(@"Initial Physical Form is GT.")]
    GTGT,
    
    /// <summary>
    /// Initial Physical Form is GP.
    /// </summary>
    [EnumMember(Value = "GPGP")]
    [IsoId("_hblKmmliEeGaMcKyqKNRfQ_145243167")]
    [Description(@"Initial Physical Form is GP.")]
    GPGP,
    
    /// <summary>
    /// Initial Physical Form is definitive.
    /// </summary>
    [EnumMember(Value = "DERN")]
    [IsoId("_hblKm2liEeGaMcKyqKNRfQ_1943280310")]
    [Description(@"Initial Physical Form is definitive.")]
    DERN,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InitialPhysicalFormCodeMetadataExtensions
{
    private static readonly InitialPhysicalFormCodeDropdownSource _dropdownSource = new InitialPhysicalFormCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInitialPhysicalFormCodeDropdownRow GetMetadata(this InitialPhysicalFormCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


