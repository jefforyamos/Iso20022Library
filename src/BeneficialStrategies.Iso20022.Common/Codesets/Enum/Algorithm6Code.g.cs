﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Algorithm6Code.  ISO2002 ID# _tw6sIAiuEeKn9O5oyej_zw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Cryptographic algorithms for encryptions with a symmetric cryptographic key.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tw6sIAiuEeKn9O5oyej_zw")]
[Description(@"Cryptographic algorithms for encryptions with a symmetric cryptographic key.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm6Code
{
    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as "AES128CBC".
    /// </summary>
    [EnumMember(Value = "EA2C")]
    [IsoId("_1z-joQiuEeKn9O5oyej_zw")]
    [Description(@"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).")]
    AES128CBC,
    
    /// <summary>
    /// Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).
    /// Encoded/decoded by serializers as "DES112CBC".
    /// </summary>
    [EnumMember(Value = "E3DC")]
    [IsoId("_2AxCcwiuEeKn9O5oyej_zw")]
    [Description(@"Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).")]
    DES112CBC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Algorithm6CodeMetadataExtensions
{
    private static readonly Algorithm6CodeDropdownSource _dropdownSource = new Algorithm6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAlgorithm6CodeDropdownRow GetMetadata(this Algorithm6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


