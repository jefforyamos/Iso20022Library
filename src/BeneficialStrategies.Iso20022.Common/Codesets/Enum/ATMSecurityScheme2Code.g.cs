﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ATMSecurityScheme2Code.  ISO2002 ID# _pdrXsIr5EeSvuOJS0mmL0g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Key exchange security schemes implemented in the hardware security module of the ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pdrXsIr5EeSvuOJS0mmL0g")]
[Description(@"Key exchange security schemes implemented in the hardware security module of the ATM.")]
[DerivedFrom(typeof(ATMSecuritySchemeCode))]
public enum ATMSecurityScheme2Code
{
    /// <summary>
    /// Application key download protected by a share symmetric key.
    /// Encoded/decoded by serializers as "APPK".
    /// </summary>
    [EnumMember(Value = "APPK")]
    [IsoId("_tB0M0Yr5EeSvuOJS0mmL0g")]
    [Description(@"Application key download protected by a share symmetric key.")]
    ApplicationRemoteKeyLoading = ATMSecuritySchemeCode.ApplicationRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a certificate.
    /// Encoded/decoded by serializers as "CERT".
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_tLaNs4r5EeSvuOJS0mmL0g")]
    [Description(@"Key download protected by asymmetric keys authenticated by a certificate.")]
    CertificateRemoteKeyLoading = ATMSecuritySchemeCode.CertificateRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download conform to the French ATM key download security scheme.
    /// Encoded/decoded by serializers as "FRAN".
    /// </summary>
    [EnumMember(Value = "FRAN")]
    [IsoId("_tNuh4Yr5EeSvuOJS0mmL0g")]
    [Description(@"Key download conform to the French ATM key download security scheme.")]
    FrenchRemoteKeyLoading = ATMSecuritySchemeCode.FrenchRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download conform to the German ATM key download security scheme.
    /// Encoded/decoded by serializers as "DTCH".
    /// </summary>
    [EnumMember(Value = "DTCH")]
    [IsoId("_tamgQ4r5EeSvuOJS0mmL0g")]
    [Description(@"Key download conform to the German ATM key download security scheme.")]
    GermanRemoteKeyLoading = ATMSecuritySchemeCode.GermanRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download conform to the Luxemburg ATM key download security scheme.
    /// Encoded/decoded by serializers as "LUXG".
    /// </summary>
    [EnumMember(Value = "LUXG")]
    [IsoId("_thGw4or5EeSvuOJS0mmL0g")]
    [Description(@"Key download conform to the Luxemburg ATM key download security scheme.")]
    LuxemburgRemoteKeyLoading = ATMSecuritySchemeCode.LuxemburgRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Manual key entry on the ATM.
    /// Encoded/decoded by serializers as "MANU".
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_tp0oAYr5EeSvuOJS0mmL0g")]
    [Description(@"Manual key entry on the ATM.")]
    ManualKeyEntry = ATMSecuritySchemeCode.ManualKeyEntry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a PKI (Public Key Infrastructure).
    /// Encoded/decoded by serializers as "PKIP".
    /// </summary>
    [EnumMember(Value = "PKIP")]
    [IsoId("_twTDc4r5EeSvuOJS0mmL0g")]
    [Description(@"Key download protected by asymmetric keys authenticated by a PKI (Public Key Infrastructure).")]
    PKIKeyDownload = ATMSecuritySchemeCode.PKIKeyDownload, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Key download protected by asymmetric keys authenticated by a digital signature.
    /// Encoded/decoded by serializers as "SIGN".
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_t1KVUYr5EeSvuOJS0mmL0g")]
    [Description(@"Key download protected by asymmetric keys authenticated by a digital signature.")]
    SignatureRemoteKeyLoading = ATMSecuritySchemeCode.SignatureRemoteKeyLoading, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ATMSecurityScheme2CodeMetadataExtensions
{
    private static readonly ATMSecurityScheme2CodeDropdownSource _dropdownSource = new ATMSecurityScheme2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IATMSecurityScheme2CodeDropdownRow GetMetadata(this ATMSecurityScheme2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


