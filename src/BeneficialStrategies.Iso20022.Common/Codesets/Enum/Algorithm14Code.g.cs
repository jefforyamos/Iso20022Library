﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Algorithm14Code.  ISO2002 ID# _iygrwWjBEeSP8Z8nx8HTuQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cryptographic algorithms for digital signatures.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_iygrwWjBEeSP8Z8nx8HTuQ")]
[Description(@"Cryptographic algorithms for digital signatures.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm14Code
{
    /// <summary>
    /// Signature algorithms with RSA, using SHA-256 digest algorithm - (ASN.1 Object Identifier: sha256WithRSAEncryption).
    /// Encoded/decoded by serializers as "ERS2".
    /// </summary>
    [EnumMember(Value = "ERS2")]
    [IsoId("_i_XcAWjBEeSP8Z8nx8HTuQ")]
    [Description(@"Signature algorithms with RSA, using SHA-256 digest algorithm - (ASN.1 Object Identifier: sha256WithRSAEncryption).")]
    SHA256WithRSA = AlgorithmCode.SHA256WithRSA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The DEPRECATED Signature algorithms with RSA (PKCS #1 version 2.1), using SHA-1 digest algorithm - (ASN.1 Object Identifier: sha1WithRSAEncryption).
    /// Encoded/decoded by serializers as "ERS1".
    /// </summary>
    [EnumMember(Value = "ERS1")]
    [IsoId("_x0rDYWjBEeSP8Z8nx8HTuQ")]
    [Description(@"The DEPRECATED Signature algorithms with RSA (PKCS #1 version 2.1), using SHA-1 digest algorithm - (ASN.1 Object Identifier: sha1WithRSAEncryption).")]
    SHA1WithRSA = AlgorithmCode.SHA1WithRSA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Signature algorithm with Appendix, Probabilistic Signature Scheme (PKCS #1 version 2.1), - (ASN.1 Object Identifier: id-RSASSA-PSS).
    /// Encoded/decoded by serializers as "RPSS".
    /// </summary>
    [EnumMember(Value = "RPSS")]
    [IsoId("_2ytDoWjBEeSP8Z8nx8HTuQ")]
    [Description(@"Signature algorithm with Appendix, Probabilistic Signature Scheme (PKCS #1 version 2.1), - (ASN.1 Object Identifier: id-RSASSA-PSS).")]
    RSASSA_PSS = AlgorithmCode.RSASSA_PSS, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Algorithm14CodeMetadataExtensions
{
    private static readonly Algorithm14CodeDropdownSource _dropdownSource = new Algorithm14CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAlgorithm14CodeDropdownRow GetMetadata(this Algorithm14Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


