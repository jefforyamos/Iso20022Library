﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthenticationMethod3Code.  ISO2002 ID# _WJVuUWjNEeSHBr6v3XO0Mg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Methods used to authenticate a person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WJVuUWjNEeSHBr6v3XO0Mg")]
[Description(@"Methods used to authenticate a person.")]
[DerivedFrom(typeof(AuthenticationMethodCode))]
public enum AuthenticationMethod3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "OnLinePIN".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WW8siWjNEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    OnLinePIN,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PaperSignature".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WW8si2jNEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    PaperSignature,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Password".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WW8sjWjNEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    Password,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecureCertificate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WW8sj2jNEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    SecureCertificate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecuredChannel".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WW8skWjNEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    SecuredChannel,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecureNoCertificate".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WW8sk2jNEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    SecureNoCertificate,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SignatureCapture".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_WW8slWjNEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    SignatureCapture,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "BillingAddressVerification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_RqDDEWjOEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    BillingAddressVerification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Biometry".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_RxyCwWjOEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    Biometry,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CardholderIdentificationData".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_XzNZsWjOEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    CardholderIdentificationData,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CryptogramVerification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_X-MhsWjOEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    CryptogramVerification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CSCVerification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_YIV8MWjOEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    CSCVerification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PassiveAuthentication".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_vs0TIWjOEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    PassiveAuthentication,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SecureElectronicCommerce".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_wKgUsWjOEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    SecureElectronicCommerce,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ShippingAddressVerification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_wc0MsWjOEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    ShippingAddressVerification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TokenAuthentication".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_wva_oWjOEeSHBr6v3XO0Mg")]
    [Description(@"??")]
    TokenAuthentication,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AuthenticationMethod3CodeMetadataExtensions
{
    private static readonly AuthenticationMethod3CodeDropdownSource _dropdownSource = new AuthenticationMethod3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAuthenticationMethod3CodeDropdownRow GetMetadata(this AuthenticationMethod3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


