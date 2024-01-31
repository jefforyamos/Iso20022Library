﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Algorithm16Code.  ISO2002 ID# _na6Hods1Eee9e6xduATmQg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256).
    /// Encoded/decoded by serializers as "HS25".
    /// </summary>
    [EnumMember(Value = "HS25")]
    [IsoId("_nmiv4ds1Eee9e6xduATmQg")]
    [Description(@"Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256).")]
    SHA256 = AlgorithmCode.SHA256, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message digest algorithm SHA-384 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha384).
    /// Encoded/decoded by serializers as "HS38".
    /// </summary>
    [EnumMember(Value = "HS38")]
    [IsoId("_nmiv49s1Eee9e6xduATmQg")]
    [Description(@"Message digest algorithm SHA-384 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha384).")]
    SHA384 = AlgorithmCode.SHA384, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message digest algorithm SHA-512 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha512).
    /// Encoded/decoded by serializers as "HS51".
    /// </summary>
    [EnumMember(Value = "HS51")]
    [IsoId("_nmiv5ds1Eee9e6xduATmQg")]
    [Description(@"Message digest algorithm SHA-512 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha512).")]
    SHA512 = AlgorithmCode.SHA512, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The DEPRECATED Message digest algorithm SHA-1 as defined in FIPS 180-1 - (ASN.1 Object Identifier: id-sha1).
    /// Encoded/decoded by serializers as "HS01".
    /// </summary>
    [EnumMember(Value = "HS01")]
    [IsoId("_nmiv59s1Eee9e6xduATmQg")]
    [Description(@"The DEPRECATED Message digest algorithm SHA-1 as defined in FIPS 180-1 - (ASN.1 Object Identifier: id-sha1).")]
    SHA1 = AlgorithmCode.SHA1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message digest algorithm SHA3-224 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-224).
    /// Encoded/decoded by serializers as "SH31".
    /// </summary>
    [EnumMember(Value = "SH31")]
    [IsoId("_q_zxwds1Eee9e6xduATmQg")]
    [Description(@"Message digest algorithm SHA3-224 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-224).")]
    SHA3_224 = AlgorithmCode.SHA3_224, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message digest algorithm SHA3-256 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-256).
    /// Encoded/decoded by serializers as "SH32".
    /// </summary>
    [EnumMember(Value = "SH32")]
    [IsoId("_rF3Wcds1Eee9e6xduATmQg")]
    [Description(@"Message digest algorithm SHA3-256 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-256).")]
    SHA3_256 = AlgorithmCode.SHA3_256, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message digest algorithm SHA3-384 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-384).
    /// Encoded/decoded by serializers as "SH33".
    /// </summary>
    [EnumMember(Value = "SH33")]
    [IsoId("_r8LTYds1Eee9e6xduATmQg")]
    [Description(@"Message digest algorithm SHA3-384 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-384).")]
    SHA3_384 = AlgorithmCode.SHA3_384, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message digest algorithm SHA3-512 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-512).
    /// Encoded/decoded by serializers as "SH35".
    /// </summary>
    [EnumMember(Value = "SH35")]
    [IsoId("_v2yu0ds1Eee9e6xduATmQg")]
    [Description(@"Message digest algorithm SHA3-512 as defined in FIPS 202 - (ASN.1 Object Identifier: id-sha3-512).")]
    SHA3_512 = AlgorithmCode.SHA3_512, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message digest algorithm SHAKE-128 as defined in FIPS 202 - (ASN.1 Object Identifier: id-shake128).
    /// Encoded/decoded by serializers as "SHK1".
    /// </summary>
    [EnumMember(Value = "SHK1")]
    [IsoId("_zzNhEds1Eee9e6xduATmQg")]
    [Description(@"Message digest algorithm SHAKE-128 as defined in FIPS 202 - (ASN.1 Object Identifier: id-shake128).")]
    SHAKE128 = AlgorithmCode.SHAKE128, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message digest algorithm SHAKE-256 as defined in FIPS 202 - (ASN.1 Object Identifier: id-shake256).
    /// Encoded/decoded by serializers as "SHK2".
    /// </summary>
    [EnumMember(Value = "SHK2")]
    [IsoId("_z6oXsds1Eee9e6xduATmQg")]
    [Description(@"Message digest algorithm SHAKE-256 as defined in FIPS 202 - (ASN.1 Object Identifier: id-shake256).")]
    SHAKE256 = AlgorithmCode.SHAKE256, // same ordinal as derivation source for type conversions
    
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


