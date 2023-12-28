﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthenticationMethod5Code.  ISO2002 ID# _TdCfEYIGEeS7UOLM47txvA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Methods used to authenticate a person or a card.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TdCfEYIGEeS7UOLM47txvA")]
[Description(@"Methods used to authenticate a person or a card.")]
[DerivedFrom(typeof(AuthenticationMethodCode))]
public enum AuthenticationMethod5Code
{
    /// <summary>
    /// On-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as "OnLinePIN".
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_Tp2zEYIGEeS7UOLM47txvA")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    OnLinePIN,
    
    /// <summary>
    /// Handwritten paper signature.
    /// Encoded/decoded by serializers as "PaperSignature".
    /// </summary>
    [EnumMember(Value = "PPSG")]
    [IsoId("_Tp2zE4IGEeS7UOLM47txvA")]
    [Description(@"Handwritten paper signature.")]
    PaperSignature,
    
    /// <summary>
    /// Authentication by a password.
    /// Encoded/decoded by serializers as "Password".
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_Tp2zFYIGEeS7UOLM47txvA")]
    [Description(@"Authentication by a password.")]
    Password,
    
    /// <summary>
    /// Electronic commerce transaction secured with the X.509 certificate of a customer.
    /// Encoded/decoded by serializers as "SecureCertificate".
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_Tp2zF4IGEeS7UOLM47txvA")]
    [Description(@"Electronic commerce transaction secured with the X.509 certificate of a customer.")]
    SecureCertificate,
    
    /// <summary>
    /// Channel-encrypted transaction.
    /// Encoded/decoded by serializers as "SecuredChannel".
    /// </summary>
    [EnumMember(Value = "SCNL")]
    [IsoId("_Tp2zGYIGEeS7UOLM47txvA")]
    [Description(@"Channel-encrypted transaction.")]
    SecuredChannel,
    
    /// <summary>
    /// Secure electronic transaction without cardholder certificate.
    /// Encoded/decoded by serializers as "SecureNoCertificate".
    /// </summary>
    [EnumMember(Value = "SNCT")]
    [IsoId("_Tp2zG4IGEeS7UOLM47txvA")]
    [Description(@"Secure electronic transaction without cardholder certificate.")]
    SecureNoCertificate,
    
    /// <summary>
    /// Electronic signature capture (handwritten signature).
    /// Encoded/decoded by serializers as "SignatureCapture".
    /// </summary>
    [EnumMember(Value = "CPSG")]
    [IsoId("_Tp2zHYIGEeS7UOLM47txvA")]
    [Description(@"Electronic signature capture (handwritten signature).")]
    SignatureCapture,
    
    /// <summary>
    /// Cardholder billing address verification.
    /// Encoded/decoded by serializers as "BillingAddressVerification".
    /// </summary>
    [EnumMember(Value = "ADDB")]
    [IsoId("_Tp2zH4IGEeS7UOLM47txvA")]
    [Description(@"Cardholder billing address verification.")]
    BillingAddressVerification,
    
    /// <summary>
    /// Biometric authentication of the cardholder.
    /// Encoded/decoded by serializers as "Biometry".
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_Tp2zIYIGEeS7UOLM47txvA")]
    [Description(@"Biometric authentication of the cardholder.")]
    Biometry,
    
    /// <summary>
    /// Cardholder data provided for verification, for instance social security number, driver license number, passport number.
    /// Encoded/decoded by serializers as "CardholderIdentificationData".
    /// </summary>
    [EnumMember(Value = "CDHI")]
    [IsoId("_Tp2zI4IGEeS7UOLM47txvA")]
    [Description(@"Cardholder data provided for verification, for instance social security number, driver license number, passport number.")]
    CardholderIdentificationData,
    
    /// <summary>
    /// Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as "CryptogramVerification".
    /// </summary>
    [EnumMember(Value = "CRYP")]
    [IsoId("_Tp2zJYIGEeS7UOLM47txvA")]
    [Description(@"Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).")]
    CryptogramVerification,
    
    /// <summary>
    /// Verification of Card Security Code.
    /// Encoded/decoded by serializers as "CSCVerification".
    /// </summary>
    [EnumMember(Value = "CSCV")]
    [IsoId("_Tp2zJ4IGEeS7UOLM47txvA")]
    [Description(@"Verification of Card Security Code.")]
    CSCVerification,
    
    /// <summary>
    /// Authentication based on statistical cardholder behaviour.
    /// Encoded/decoded by serializers as "PassiveAuthentication".
    /// </summary>
    [EnumMember(Value = "PSVE")]
    [IsoId("_Tp2zKYIGEeS7UOLM47txvA")]
    [Description(@"Authentication based on statistical cardholder behaviour.")]
    PassiveAuthentication,
    
    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as "SecureElectronicCommerce".
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_Tp2zK4IGEeS7UOLM47txvA")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    SecureElectronicCommerce,
    
    /// <summary>
    /// Cardholder shipping address verification.
    /// Encoded/decoded by serializers as "ShippingAddressVerification".
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_Tp2zLYIGEeS7UOLM47txvA")]
    [Description(@"Cardholder shipping address verification.")]
    ShippingAddressVerification,
    
    /// <summary>
    /// Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.
    /// Encoded/decoded by serializers as "PaymentToken".
    /// </summary>
    [EnumMember(Value = "TOKP")]
    [IsoId("_b119EYIGEeS7UOLM47txvA")]
    [Description(@"Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.")]
    PaymentToken,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AuthenticationMethod5CodeMetadataExtensions
{
    private static readonly AuthenticationMethod5CodeDropdownSource _dropdownSource = new AuthenticationMethod5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAuthenticationMethod5CodeDropdownRow GetMetadata(this AuthenticationMethod5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


