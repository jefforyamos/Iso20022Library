﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthenticationMethod8Code.  ISO2002 ID# _8I3roNtmEeipuvJHTHIw9A.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Encoded/decoded by serializers as &quot;TOKA&quot;.
    /// </summary>
    [EnumMember(Value = "TOKA")]
    [IsoId("__gl1YdtmEeipuvJHTHIw9A")]
    [Description(@"A token is used to verify an already performed authentication.")]
    AuthenticationToken = AuthenticationMethodCode.AuthenticationToken, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder billing address verification.
    /// Encoded/decoded by serializers as &quot;ADDB&quot;.
    /// </summary>
    [EnumMember(Value = "ADDB")]
    [IsoId("_AA7iUdtnEeipuvJHTHIw9A")]
    [Description(@"Cardholder billing address verification.")]
    BillingAddressVerification = AuthenticationMethodCode.BillingAddressVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication bypassed by the merchant.
    /// Encoded/decoded by serializers as &quot;BYPS&quot;.
    /// </summary>
    [EnumMember(Value = "BYPS")]
    [IsoId("_AewGwdtnEeipuvJHTHIw9A")]
    [Description(@"Authentication bypassed by the merchant.")]
    Bypass = AuthenticationMethodCode.Bypass, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Biometric authentication of the cardholder.
    /// Encoded/decoded by serializers as &quot;BIOM&quot;.
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_AloK0dtnEeipuvJHTHIw9A")]
    [Description(@"Biometric authentication of the cardholder.")]
    Biometry = AuthenticationMethodCode.Biometry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder data provided for verification, for instance social security number, driver license number, passport number.
    /// Encoded/decoded by serializers as &quot;CDHI&quot;.
    /// </summary>
    [EnumMember(Value = "CDHI")]
    [IsoId("_BJ7xwdtnEeipuvJHTHIw9A")]
    [Description(@"Cardholder data provided for verification, for instance social security number, driver license number, passport number.")]
    CardholderIdentificationData = AuthenticationMethodCode.CardholderIdentificationData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as &quot;CRYP&quot;.
    /// </summary>
    [EnumMember(Value = "CRYP")]
    [IsoId("_ByEv0dtnEeipuvJHTHIw9A")]
    [Description(@"Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).")]
    CryptogramVerification = AuthenticationMethodCode.CryptogramVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification of Card Security Code.
    /// Encoded/decoded by serializers as &quot;CSCV&quot;.
    /// </summary>
    [EnumMember(Value = "CSCV")]
    [IsoId("_B5Pu0dtnEeipuvJHTHIw9A")]
    [Description(@"Verification of Card Security Code.")]
    CSCVerification = AuthenticationMethodCode.CSCVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as &quot;MANU&quot;.
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_CQNdUdtnEeipuvJHTHIw9A")]
    [Description(@"Manual verification, for example passport or drivers license.")]
    ManualVerification = AuthenticationMethodCode.ManualVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant-related authentication.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_CmVeUdtnEeipuvJHTHIw9A")]
    [Description(@"Merchant-related authentication.")]
    MerchantAuthentication = AuthenticationMethodCode.MerchantAuthentication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer mobile device.
    /// Encoded/decoded by serializers as &quot;MOBL&quot;.
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_CwZZQdtnEeipuvJHTHIw9A")]
    [Description(@"Customer mobile device.")]
    Mobile = AuthenticationMethodCode.Mobile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Off-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FPIN&quot;.
    /// </summary>
    [EnumMember(Value = "FPIN")]
    [IsoId("_DFYx0dtnEeipuvJHTHIw9A")]
    [Description(@"Off-line PIN authentication (Personal Identification Number).")]
    OfflinePIN = AuthenticationMethodCode.OfflinePIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// On-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;NPIN&quot;.
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_DNK00dtnEeipuvJHTHIw9A")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    OnLinePIN = AuthenticationMethodCode.OnLinePIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other customer authentication.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_DpinwdtnEeipuvJHTHIw9A")]
    [Description(@"Other customer authentication.")]
    Other = AuthenticationMethodCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Handwritten paper signature.
    /// Encoded/decoded by serializers as &quot;PPSG&quot;.
    /// </summary>
    [EnumMember(Value = "PPSG")]
    [IsoId("_Dulf0dtnEeipuvJHTHIw9A")]
    [Description(@"Handwritten paper signature.")]
    PaperSignature = AuthenticationMethodCode.PaperSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication based on statistical cardholder behaviour.
    /// Encoded/decoded by serializers as &quot;PSVE&quot;.
    /// </summary>
    [EnumMember(Value = "PSVE")]
    [IsoId("_ES-mUdtnEeipuvJHTHIw9A")]
    [Description(@"Authentication based on statistical cardholder behaviour.")]
    PassiveAuthentication = AuthenticationMethodCode.PassiveAuthentication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication by a password.
    /// Encoded/decoded by serializers as &quot;PSWD&quot;.
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_EpfB0dtnEeipuvJHTHIw9A")]
    [Description(@"Authentication by a password.")]
    Password = AuthenticationMethodCode.Password, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.
    /// Encoded/decoded by serializers as &quot;TOKP&quot;.
    /// </summary>
    [EnumMember(Value = "TOKP")]
    [IsoId("_Ez3F0dtnEeipuvJHTHIw9A")]
    [Description(@"Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.")]
    PaymentToken = AuthenticationMethodCode.PaymentToken, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Electronic commerce transaction secured with the X.509 certificate of a customer.
    /// Encoded/decoded by serializers as &quot;SCRT&quot;.
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_FXBdQdtnEeipuvJHTHIw9A")]
    [Description(@"Electronic commerce transaction secured with the X.509 certificate of a customer.")]
    SecureCertificate = AuthenticationMethodCode.SecureCertificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Channel-encrypted transaction.
    /// Encoded/decoded by serializers as &quot;SCNL&quot;.
    /// </summary>
    [EnumMember(Value = "SCNL")]
    [IsoId("_Fbiw4dtnEeipuvJHTHIw9A")]
    [Description(@"Channel-encrypted transaction.")]
    SecuredChannel = AuthenticationMethodCode.SecuredChannel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as &quot;CSEC&quot;.
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_GkeH0dtnEeipuvJHTHIw9A")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    SecureElectronicCommerce = AuthenticationMethodCode.SecureElectronicCommerce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Secure electronic transaction without cardholder certificate.
    /// Encoded/decoded by serializers as &quot;SNCT&quot;.
    /// </summary>
    [EnumMember(Value = "SNCT")]
    [IsoId("_HEvjUdtnEeipuvJHTHIw9A")]
    [Description(@"Secure electronic transaction without cardholder certificate.")]
    SecureNoCertificate = AuthenticationMethodCode.SecureNoCertificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder shipping address verification.
    /// Encoded/decoded by serializers as &quot;ADDS&quot;.
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_HkokUdtnEeipuvJHTHIw9A")]
    [Description(@"Cardholder shipping address verification.")]
    ShippingAddressVerification = AuthenticationMethodCode.ShippingAddressVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Electronic signature capture (handwritten signature).
    /// Encoded/decoded by serializers as &quot;CPSG&quot;.
    /// </summary>
    [EnumMember(Value = "CPSG")]
    [IsoId("_HqNA0dtnEeipuvJHTHIw9A")]
    [Description(@"Electronic signature capture (handwritten signature).")]
    SignatureCapture = AuthenticationMethodCode.SignatureCapture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_IBjJ0dtnEeipuvJHTHIw9A")]
    [Description(@"Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.")]
    TokenAuthentication = AuthenticationMethodCode.TokenAuthentication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication method is performed unknown.
    /// Encoded/decoded by serializers as &quot;UKNW&quot;.
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_ILAn0dtnEeipuvJHTHIw9A")]
    [Description(@"Authentication method is performed unknown.")]
    UnknownMethod = AuthenticationMethodCode.UnknownMethod, // same ordinal as derivation source for type conversions
    
}
