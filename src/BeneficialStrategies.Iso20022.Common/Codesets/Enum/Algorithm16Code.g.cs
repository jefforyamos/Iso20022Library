﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Algorithm16Code.  ISO2002 ID# _na6Hods1Eee9e6xduATmQg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of a digest algorithm.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_na6Hods1Eee9e6xduATmQg")]
[Description(@"Identification of a digest algorithm.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm16Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA256".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nmiv4ds1Eee9e6xduATmQg")]
    [Description(@"??")]
    SHA256,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA384".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nmiv49s1Eee9e6xduATmQg")]
    [Description(@"??")]
    SHA384,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA512".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nmiv5ds1Eee9e6xduATmQg")]
    [Description(@"??")]
    SHA512,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_nmiv59s1Eee9e6xduATmQg")]
    [Description(@"??")]
    SHA1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA3_224".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_q_zxwds1Eee9e6xduATmQg")]
    [Description(@"??")]
    SHA3_224,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA3_256".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_rF3Wcds1Eee9e6xduATmQg")]
    [Description(@"??")]
    SHA3_256,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA3_384".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_r8LTYds1Eee9e6xduATmQg")]
    [Description(@"??")]
    SHA3_384,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHA3_512".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_v2yu0ds1Eee9e6xduATmQg")]
    [Description(@"??")]
    SHA3_512,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHAKE128".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zzNhEds1Eee9e6xduATmQg")]
    [Description(@"??")]
    SHAKE128,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SHAKE256".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_z6oXsds1Eee9e6xduATmQg")]
    [Description(@"??")]
    SHAKE256,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Algorithm16CodeMetadataExtensions
{
    private static readonly Algorithm16CodeDropdownSource _dropdownSource = new Algorithm16CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAlgorithm16CodeDropdownRow GetMetadata(this Algorithm16Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

