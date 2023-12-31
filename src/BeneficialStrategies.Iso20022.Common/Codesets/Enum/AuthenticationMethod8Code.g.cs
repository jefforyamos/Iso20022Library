﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthenticationMethod8Code.  ISO2002 ID# _8I3roNtmEeipuvJHTHIw9A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method to authenticate the customer or its card.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8I3roNtmEeipuvJHTHIw9A")]
[Description(@"Method to authenticate the customer or its card.")]
[DerivedFrom(typeof(AuthenticationMethodCode))]
public enum AuthenticationMethod8Code
{
    /// <summary>
    /// A token is used to verify an already performed authentication.
    /// Encoded/decoded by serializers as "AuthenticationToken".
    /// </summary>
    [EnumMember(Value = "TOKA")]
    [IsoId("__gl1YdtmEeipuvJHTHIw9A")]
    [Description(@"A token is used to verify an already performed authentication.")]
    AuthenticationToken,
    
    /// <summary>
    /// Cardholder billing address verification.
    /// Encoded/decoded by serializers as "BillingAddressVerification".
    /// </summary>
    [EnumMember(Value = "ADDB")]
    [IsoId("_AA7iUdtnEeipuvJHTHIw9A")]
    [Description(@"Cardholder billing address verification.")]
    BillingAddressVerification,
    
    /// <summary>
    /// Authentication bypassed by the merchant.
    /// Encoded/decoded by serializers as "Bypass".
    /// </summary>
    [EnumMember(Value = "BYPS")]
    [IsoId("_AewGwdtnEeipuvJHTHIw9A")]
    [Description(@"Authentication bypassed by the merchant.")]
    Bypass,
    
    /// <summary>
    /// Biometric authentication of the cardholder.
    /// Encoded/decoded by serializers as "Biometry".
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_AloK0dtnEeipuvJHTHIw9A")]
    [Description(@"Biometric authentication of the cardholder.")]
    Biometry,
    
    /// <summary>
    /// Cardholder data provided for verification, for instance social security number, driver license number, passport number.
    /// Encoded/decoded by serializers as "CardholderIdentificationData".
    /// </summary>
    [EnumMember(Value = "CDHI")]
    [IsoId("_BJ7xwdtnEeipuvJHTHIw9A")]
    [Description(@"Cardholder data provided for verification, for instance social security number, driver license number, passport number.")]
    CardholderIdentificationData,
    
    /// <summary>
    /// Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as "CryptogramVerification".
    /// </summary>
    [EnumMember(Value = "CRYP")]
    [IsoId("_ByEv0dtnEeipuvJHTHIw9A")]
    [Description(@"Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).")]
    CryptogramVerification,
    
    /// <summary>
    /// Verification of Card Security Code.
    /// Encoded/decoded by serializers as "CSCVerification".
    /// </summary>
    [EnumMember(Value = "CSCV")]
    [IsoId("_B5Pu0dtnEeipuvJHTHIw9A")]
    [Description(@"Verification of Card Security Code.")]
    CSCVerification,
    
    /// <summary>
    /// Manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as "ManualVerification".
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_CQNdUdtnEeipuvJHTHIw9A")]
    [Description(@"Manual verification, for example passport or drivers license.")]
    ManualVerification,
    
    /// <summary>
    /// Merchant-related authentication.
    /// Encoded/decoded by serializers as "MerchantAuthentication".
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_CmVeUdtnEeipuvJHTHIw9A")]
    [Description(@"Merchant-related authentication.")]
    MerchantAuthentication,
    
    /// <summary>
    /// Customer mobile device.
    /// Encoded/decoded by serializers as "Mobile".
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_CwZZQdtnEeipuvJHTHIw9A")]
    [Description(@"Customer mobile device.")]
    Mobile,
    
    /// <summary>
    /// Off-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as "OfflinePIN".
    /// </summary>
    [EnumMember(Value = "FPIN")]
    [IsoId("_DFYx0dtnEeipuvJHTHIw9A")]
    [Description(@"Off-line PIN authentication (Personal Identification Number).")]
    OfflinePIN,
    
    /// <summary>
    /// On-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as "OnLinePIN".
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_DNK00dtnEeipuvJHTHIw9A")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    OnLinePIN,
    
    /// <summary>
    /// Other customer authentication.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_DpinwdtnEeipuvJHTHIw9A")]
    [Description(@"Other customer authentication.")]
    Other,
    
    /// <summary>
    /// Handwritten paper signature.
    /// Encoded/decoded by serializers as "PaperSignature".
    /// </summary>
    [EnumMember(Value = "PPSG")]
    [IsoId("_Dulf0dtnEeipuvJHTHIw9A")]
    [Description(@"Handwritten paper signature.")]
    PaperSignature,
    
    /// <summary>
    /// Authentication based on statistical cardholder behaviour.
    /// Encoded/decoded by serializers as "PassiveAuthentication".
    /// </summary>
    [EnumMember(Value = "PSVE")]
    [IsoId("_ES-mUdtnEeipuvJHTHIw9A")]
    [Description(@"Authentication based on statistical cardholder behaviour.")]
    PassiveAuthentication,
    
    /// <summary>
    /// Authentication by a password.
    /// Encoded/decoded by serializers as "Password".
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_EpfB0dtnEeipuvJHTHIw9A")]
    [Description(@"Authentication by a password.")]
    Password,
    
    /// <summary>
    /// Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.
    /// Encoded/decoded by serializers as "PaymentToken".
    /// </summary>
    [EnumMember(Value = "TOKP")]
    [IsoId("_Ez3F0dtnEeipuvJHTHIw9A")]
    [Description(@"Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.")]
    PaymentToken,
    
    /// <summary>
    /// Electronic commerce transaction secured with the X.509 certificate of a customer.
    /// Encoded/decoded by serializers as "SecureCertificate".
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_FXBdQdtnEeipuvJHTHIw9A")]
    [Description(@"Electronic commerce transaction secured with the X.509 certificate of a customer.")]
    SecureCertificate,
    
    /// <summary>
    /// Channel-encrypted transaction.
    /// Encoded/decoded by serializers as "SecuredChannel".
    /// </summary>
    [EnumMember(Value = "SCNL")]
    [IsoId("_Fbiw4dtnEeipuvJHTHIw9A")]
    [Description(@"Channel-encrypted transaction.")]
    SecuredChannel,
    
    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as "SecureElectronicCommerce".
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_GkeH0dtnEeipuvJHTHIw9A")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    SecureElectronicCommerce,
    
    /// <summary>
    /// Secure electronic transaction without cardholder certificate.
    /// Encoded/decoded by serializers as "SecureNoCertificate".
    /// </summary>
    [EnumMember(Value = "SNCT")]
    [IsoId("_HEvjUdtnEeipuvJHTHIw9A")]
    [Description(@"Secure electronic transaction without cardholder certificate.")]
    SecureNoCertificate,
    
    /// <summary>
    /// Cardholder shipping address verification.
    /// Encoded/decoded by serializers as "ShippingAddressVerification".
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_HkokUdtnEeipuvJHTHIw9A")]
    [Description(@"Cardholder shipping address verification.")]
    ShippingAddressVerification,
    
    /// <summary>
    /// Electronic signature capture (handwritten signature).
    /// Encoded/decoded by serializers as "SignatureCapture".
    /// </summary>
    [EnumMember(Value = "CPSG")]
    [IsoId("_HqNA0dtnEeipuvJHTHIw9A")]
    [Description(@"Electronic signature capture (handwritten signature).")]
    SignatureCapture,
    
    /// <summary>
    /// Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.
    /// Encoded/decoded by serializers as "TokenAuthentication".
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_IBjJ0dtnEeipuvJHTHIw9A")]
    [Description(@"Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.")]
    TokenAuthentication,
    
    /// <summary>
    /// Authentication method is performed unknown.
    /// Encoded/decoded by serializers as "UnknownMethod".
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_ILAn0dtnEeipuvJHTHIw9A")]
    [Description(@"Authentication method is performed unknown.")]
    UnknownMethod,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AuthenticationMethod8CodeMetadataExtensions
{
    private static readonly AuthenticationMethod8CodeDropdownSource _dropdownSource = new AuthenticationMethod8CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAuthenticationMethod8CodeDropdownRow GetMetadata(this AuthenticationMethod8Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


