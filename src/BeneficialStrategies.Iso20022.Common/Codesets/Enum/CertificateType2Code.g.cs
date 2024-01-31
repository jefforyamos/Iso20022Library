﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CertificateType2Code.  ISO2002 ID# _GXDp0BODEeKjmvxNCObNeQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of certificate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_GXDp0BODEeKjmvxNCObNeQ")]
[Description(@"Specifies the type of certificate.")]
[DerivedFrom(typeof(CertificateTypeCode))]
public enum CertificateType2Code
{
    /// <summary>
    /// Anti-money laundering certification form.
    /// Encoded/decoded by serializers as "AMLC".
    /// </summary>
    [EnumMember(Value = "AMLC")]
    [IsoId("_MX05cRODEeKjmvxNCObNeQ")]
    [Description(@"Anti-money laundering certification form.")]
    AntiMoneyLaundering = CertificateTypeCode.AntiMoneyLaundering, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Government issued form of picture identification - driving license.
    /// Encoded/decoded by serializers as "DVLC".
    /// </summary>
    [EnumMember(Value = "DVLC")]
    [IsoId("_MkCwgRODEeKjmvxNCObNeQ")]
    [Description(@"Government issued form of picture identification - driving license.")]
    DrivingLicense = CertificateTypeCode.DrivingLicense, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certification of due formation and organisation.
    /// Encoded/decoded by serializers as "DFOR".
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_MvhAsRODEeKjmvxNCObNeQ")]
    [Description(@"Certification of due formation and organisation.")]
    DueFormationAndOrganisation = CertificateTypeCode.DueFormationAndOrganisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate of good standing.
    /// Encoded/decoded by serializers as "GOST".
    /// </summary>
    [EnumMember(Value = "GOST")]
    [IsoId("_M6jMARODEeKjmvxNCObNeQ")]
    [Description(@"Certificate of good standing.")]
    GoodStanding = CertificateTypeCode.GoodStanding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Government issued form of picture identification - identity card.
    /// Encoded/decoded by serializers as "IDEN".
    /// </summary>
    [EnumMember(Value = "IDEN")]
    [IsoId("_NHqa8RODEeKjmvxNCObNeQ")]
    [Description(@"Government issued form of picture identification - identity card.")]
    IdentityCard = CertificateTypeCode.IdentityCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certification of incumbency.
    /// Encoded/decoded by serializers as "INCU".
    /// </summary>
    [EnumMember(Value = "INCU")]
    [IsoId("_NacNARODEeKjmvxNCObNeQ")]
    [Description(@"Certification of incumbency.")]
    Incumbency = CertificateTypeCode.Incumbency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Letter of reference.
    /// Encoded/decoded by serializers as "LREF".
    /// </summary>
    [EnumMember(Value = "LREF")]
    [IsoId("_NpCpsRODEeKjmvxNCObNeQ")]
    [Description(@"Letter of reference.")]
    LetterOfReference = CertificateTypeCode.LetterOfReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Government issued form of picture identification - passport.
    /// Encoded/decoded by serializers as "PASS".
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_N1HW0RODEeKjmvxNCObNeQ")]
    [Description(@"Government issued form of picture identification - passport.")]
    Passport = CertificateTypeCode.Passport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Proof of the address, such as a utility bill.
    /// Encoded/decoded by serializers as "PRAD".
    /// </summary>
    [EnumMember(Value = "PRAD")]
    [IsoId("_OE6GURODEeKjmvxNCObNeQ")]
    [Description(@"Proof of the address, such as a utility bill.")]
    ProofOfAddress = CertificateTypeCode.ProofOfAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Public key infrastructure certificate.
    /// Encoded/decoded by serializers as "PKIC".
    /// </summary>
    [EnumMember(Value = "PKIC")]
    [IsoId("_OPV0sRODEeKjmvxNCObNeQ")]
    [Description(@"Public key infrastructure certificate.")]
    PublicKeyInfrastructureCertificate = CertificateTypeCode.PublicKeyInfrastructureCertificate, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CertificateType2CodeMetadataExtensions
{
    private static readonly CertificateType2CodeDropdownSource _dropdownSource = new CertificateType2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICertificateType2CodeDropdownRow GetMetadata(this CertificateType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


