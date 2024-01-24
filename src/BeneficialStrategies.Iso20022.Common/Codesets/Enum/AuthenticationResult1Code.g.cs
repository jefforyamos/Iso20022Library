﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthenticationResult1Code.  ISO2002 ID# _rETL4Pm3EeaYndR2y_Ep9g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the result of authentication done.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rETL4Pm3EeaYndR2y_Ep9g")]
[Description(@"Specifies the result of authentication done.")]
[DerivedFrom(typeof(AuthenticationResultCode))]
public enum AuthenticationResult1Code
{
    /// <summary>
    /// The authentication didn’t succeed.
    /// Encoded/decoded by serializers as "DENY".
    /// </summary>
    [EnumMember(Value = "DENY")]
    [IsoId("_vwOIcfm3EeaYndR2y_Ep9g")]
    [Description(@"The authentication didn’t succeed.")]
    Denial = AuthenticationResultCode.Denial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant not enrolled in the authentication programme.
    /// Encoded/decoded by serializers as "MRCH".
    /// </summary>
    [EnumMember(Value = "MRCH")]
    [IsoId("_v3DwQfm3EeaYndR2y_Ep9g")]
    [Description(@"Merchant not enrolled in the authentication programme.")]
    MerchantNotEnroled = AuthenticationResultCode.MerchantNotEnroled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The card does not participate in the authentication programme.
    /// Encoded/decoded by serializers as "CARD".
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_v9wOIfm3EeaYndR2y_Ep9g")]
    [Description(@"The card does not participate in the authentication programme.")]
    NonParticipation = AuthenticationResultCode.NonParticipation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The authentication couldn’t be carried out.
    /// Encoded/decoded by serializers as "AUTH".
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_wHR9kfm3EeaYndR2y_Ep9g")]
    [Description(@"The authentication couldn’t be carried out.")]
    UnableToAuthenticate = AuthenticationResultCode.UnableToAuthenticate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication succeeded with a cryptogram.
    /// Encoded/decoded by serializers as "CRPT".
    /// </summary>
    [EnumMember(Value = "CRPT")]
    [IsoId("_wMfNsfm3EeaYndR2y_Ep9g")]
    [Description(@"Authentication succeeded with a cryptogram.")]
    WithCryptogram = AuthenticationResultCode.WithCryptogram, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication succeeded without a cryptogram.
    /// Encoded/decoded by serializers as "UCRP".
    /// </summary>
    [EnumMember(Value = "UCRP")]
    [IsoId("_wR_Ywfm3EeaYndR2y_Ep9g")]
    [Description(@"Authentication succeeded without a cryptogram.")]
    WithoutCryptogram = AuthenticationResultCode.WithoutCryptogram, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AuthenticationResult1CodeMetadataExtensions
{
    private static readonly AuthenticationResult1CodeDropdownSource _dropdownSource = new AuthenticationResult1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAuthenticationResult1CodeDropdownRow GetMetadata(this AuthenticationResult1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


