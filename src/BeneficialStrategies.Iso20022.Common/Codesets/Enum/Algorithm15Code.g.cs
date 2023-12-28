﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Algorithm15Code.  ISO2002 ID# _-7tyIWjBEeSP8Z8nx8HTuQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Cryptographic algorithms for encryptions with a symmetric cryptographic key.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-7tyIWjBEeSP8Z8nx8HTuQ")]
[Description(@"Cryptographic algorithms for encryptions with a symmetric cryptographic key.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm15Code
{
    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as "AES128CBC".
    /// </summary>
    [EnumMember(Value = "EA2C")]
    [IsoId("__IaKUWjBEeSP8Z8nx8HTuQ")]
    [Description(@"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 128 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 - November 6, 2001 - Advanced Encryption Standard).")]
    AES128CBC,
    
    /// <summary>
    /// Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).
    /// Encoded/decoded by serializers as "DES112CBC".
    /// </summary>
    [EnumMember(Value = "E3DC")]
    [IsoId("__IaKU2jBEeSP8Z8nx8HTuQ")]
    [Description(@"Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).")]
    DES112CBC,
    
    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as "AES192CBC".
    /// </summary>
    [EnumMember(Value = "EA9C")]
    [IsoId("_DT3eIWjCEeSP8Z8nx8HTuQ")]
    [Description(@"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 192 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).")]
    AES192CBC,
    
    /// <summary>
    /// AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).
    /// Encoded/decoded by serializers as "AES256CBC".
    /// </summary>
    [EnumMember(Value = "EA5C")]
    [IsoId("_DeJbgWjCEeSP8Z8nx8HTuQ")]
    [Description(@"AES (Advanced Encryption Standard) CBC (Chaining Block Cypher) encryption with a 256 bits cryptographic key as defined by the Federal Information Processing Standards (FIPS 197 – November 6, 2001 - Advanced Encryption Standard).")]
    AES256CBC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Algorithm15CodeMetadataExtensions
{
    private static readonly Algorithm15CodeDropdownSource _dropdownSource = new Algorithm15CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAlgorithm15CodeDropdownRow GetMetadata(this Algorithm15Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


