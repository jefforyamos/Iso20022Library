﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Algorithm1Code.  ISO2002 ID# _TR6hjAEcEeCQm6a_G2yO_w_11890629.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of a cryptographic algorithm.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TR6hjAEcEeCQm6a_G2yO_w_11890629")]
[Description(@"Identification of a cryptographic algorithm.")]
[DerivedFrom(typeof(AlgorithmCode))]
public enum Algorithm1Code
{
    /// <summary>
    /// Retail CBC (Chaining Block Cypher) MAC (Message Authentication Code) (cf. ISO 9807, ANSI X9.19) - (ASN.1 Object Identifier: id-retail-cbc-mac).
    /// Encoded/decoded by serializers as "RetailCBCMAC".
    /// </summary>
    [EnumMember(Value = "MACC")]
    [IsoId("_TR6hjQEcEeCQm6a_G2yO_w_-1087858168")]
    [Description(@"Retail CBC (Chaining Block Cypher) MAC (Message Authentication Code) (cf. ISO 9807, ANSI X9.19) - (ASN.1 Object Identifier: id-retail-cbc-mac).")]
    RetailCBCMAC,
    
    /// <summary>
    /// Retail-CBC-MAC with SHA-256 (Secure HAsh standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-256).
    /// Encoded/decoded by serializers as "RetailSHA256MAC".
    /// </summary>
    [EnumMember(Value = "MCCS")]
    [IsoId("_TR6hjgEcEeCQm6a_G2yO_w_-1148105855")]
    [Description(@"Retail-CBC-MAC with SHA-256 (Secure HAsh standard) - (ASN.1 Object Identifier: id-retail-cbc-mac-sha-256).")]
    RetailSHA256MAC,
    
    /// <summary>
    /// UKPT (Unique Key Per Transaction) or Master Session Key key encryption - (ASN.1 Object Identifier: id-ukpt-wrap).
    /// Encoded/decoded by serializers as "UKPT".
    /// </summary>
    [EnumMember(Value = "UKPT")]
    [IsoId("_TR6hjwEcEeCQm6a_G2yO_w_789119318")]
    [Description(@"UKPT (Unique Key Per Transaction) or Master Session Key key encryption - (ASN.1 Object Identifier: id-ukpt-wrap).")]
    UKPT,
    
    /// <summary>
    /// DUKPT (Derived Unique Key Per Transaction) algorithm, as specified in ANSI X9.24-2004, Annex A, and ISO/DIS 13492-2006. - (ASN.1 Object Identifier: id-dukpt-wrap).
    /// Encoded/decoded by serializers as "DUKPT".
    /// </summary>
    [EnumMember(Value = "DKPT")]
    [IsoId("_TR6hkAEcEeCQm6a_G2yO_w_1019033598")]
    [Description(@"DUKPT (Derived Unique Key Per Transaction) algorithm, as specified in ANSI X9.24-2004, Annex A, and ISO/DIS 13492-2006. - (ASN.1 Object Identifier: id-dukpt-wrap).")]
    DUKPT,
    
    /// <summary>
    /// Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).
    /// Encoded/decoded by serializers as "DES112CBC".
    /// </summary>
    [EnumMember(Value = "E3DC")]
    [IsoId("_TR6hkQEcEeCQm6a_G2yO_w_2097053936")]
    [Description(@"Triple DES (Data Encryption Standard) CBC (Chaining Block Cypher) encryption with double length key (112 Bit) as defined in FIPS PUB 46-3 - (ASN.1 Object Identifier: des-ede3-cbc).")]
    DES112CBC,
    
    /// <summary>
    /// Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256).
    /// Encoded/decoded by serializers as "SHA256".
    /// </summary>
    [EnumMember(Value = "HS25")]
    [IsoId("_TSESgAEcEeCQm6a_G2yO_w_-260688187")]
    [Description(@"Message digest algorithm SHA-256 as defined in FIPS 180-1 and 2 - (ASN.1 Object Identifier: id-sha256).")]
    SHA256,
    
    /// <summary>
    /// Signature algorithms with RSA, using SHA-256 digest algorithm - (ASN.1 Object Identifier: sha256WithRSAEncryption).
    /// Encoded/decoded by serializers as "SHA256WithRSA".
    /// </summary>
    [EnumMember(Value = "ERS2")]
    [IsoId("_TSESgQEcEeCQm6a_G2yO_w_-1743826091")]
    [Description(@"Signature algorithms with RSA, using SHA-256 digest algorithm - (ASN.1 Object Identifier: sha256WithRSAEncryption).")]
    SHA256WithRSA,
    
    /// <summary>
    /// RSA encryption algorithm - (ASN.1 Object Identifier: rsaEncryption).
    /// Encoded/decoded by serializers as "RSAEncryption".
    /// </summary>
    [EnumMember(Value = "ERSA")]
    [IsoId("_TSESggEcEeCQm6a_G2yO_w_193399082")]
    [Description(@"RSA encryption algorithm - (ASN.1 Object Identifier: rsaEncryption).")]
    RSAEncryption,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Algorithm1CodeMetadataExtensions
{
    private static readonly Algorithm1CodeDropdownSource _dropdownSource = new Algorithm1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAlgorithm1CodeDropdownRow GetMetadata(this Algorithm1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


