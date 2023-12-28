﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthenticationResultCode.  ISO2002 ID# _Zg1qsLABEeah1_v59tW6Rg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the result of authentication done.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zg1qsLABEeah1_v59tW6Rg")]
[Description(@"Specifies the result of authentication done.")]
public enum AuthenticationResultCode
{
    /// <summary>
    /// The authentication didn’t succeed.
    /// Encoded/decoded by serializers as "DENY".
    /// </summary>
    [EnumMember(Value = "DENY")]
    [IsoId("_pHOwwLABEeah1_v59tW6Rg")]
    [Description(@"The authentication didn’t succeed.")]
    Denial,
    
    /// <summary>
    /// The card does not participate in the authentication programme.
    /// Encoded/decoded by serializers as "CARD".
    /// </summary>
    [EnumMember(Value = "CARD")]
    [IsoId("_vTZYELABEeah1_v59tW6Rg")]
    [Description(@"The card does not participate in the authentication programme.")]
    NonParticipation,
    
    /// <summary>
    /// The authentication couldn’t be carried out.
    /// Encoded/decoded by serializers as "AUTH".
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_zS4FYLABEeah1_v59tW6Rg")]
    [Description(@"The authentication couldn’t be carried out.")]
    UnableToAuthenticate,
    
    /// <summary>
    /// Merchant not enrolled in the authentication programme.
    /// Encoded/decoded by serializers as "MRCH".
    /// </summary>
    [EnumMember(Value = "MRCH")]
    [IsoId("_41PhwLABEeah1_v59tW6Rg")]
    [Description(@"Merchant not enrolled in the authentication programme.")]
    MerchantNotEnroled,
    
    /// <summary>
    /// Authentication succeeded with a cryptogram.
    /// Encoded/decoded by serializers as "CRPT".
    /// </summary>
    [EnumMember(Value = "CRPT")]
    [IsoId("_8GEZULABEeah1_v59tW6Rg")]
    [Description(@"Authentication succeeded with a cryptogram.")]
    WithCryptogram,
    
    /// <summary>
    /// Authentication succeeded without a cryptogram.
    /// Encoded/decoded by serializers as "UCRP".
    /// </summary>
    [EnumMember(Value = "UCRP")]
    [IsoId("__VGhILABEeah1_v59tW6Rg")]
    [Description(@"Authentication succeeded without a cryptogram.")]
    WithoutCryptogram,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AuthenticationResultCodeMetadataExtensions
{
    private static readonly AuthenticationResultCodeDropdownSource _dropdownSource = new AuthenticationResultCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAuthenticationResultCodeDropdownRow GetMetadata(this AuthenticationResultCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

