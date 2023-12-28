﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Algorithm20Code.  ISO2002 ID# _EGOq0aRHEeeWXKXf3KjtmQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of a digest algorithm.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EGOq0aRHEeeWXKXf3KjtmQ")]
[Description(@"Identification of a digest algorithm.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm20Code
{
    /// <summary>
    /// Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256).
    /// Encoded/decoded by serializers as "SHA256".
    /// </summary>
    [EnumMember(Value = "HS25")]
    [IsoId("_ER020aRHEeeWXKXf3KjtmQ")]
    [Description(@"Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256).")]
    SHA256,
    
    /// <summary>
    /// Message digest algorithm SHA-384 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha384).
    /// Encoded/decoded by serializers as "SHA384".
    /// </summary>
    [EnumMember(Value = "HS38")]
    [IsoId("_ER0206RHEeeWXKXf3KjtmQ")]
    [Description(@"Message digest algorithm SHA-384 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha384).")]
    SHA384,
    
    /// <summary>
    /// Message digest algorithm SHA-512 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha512).
    /// Encoded/decoded by serializers as "SHA512".
    /// </summary>
    [EnumMember(Value = "HS51")]
    [IsoId("_ER021aRHEeeWXKXf3KjtmQ")]
    [Description(@"Message digest algorithm SHA-512 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha512).")]
    SHA512,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Algorithm20CodeMetadataExtensions
{
    private static readonly Algorithm20CodeDropdownSource _dropdownSource = new Algorithm20CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAlgorithm20CodeDropdownRow GetMetadata(this Algorithm20Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


