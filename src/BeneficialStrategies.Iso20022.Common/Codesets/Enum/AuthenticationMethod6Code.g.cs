﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthenticationMethod6Code.  ISO2002 ID# _pBFH8YIJEeS7UOLM47txvA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Methods used to authenticate a person or a card.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pBFH8YIJEeS7UOLM47txvA")]
[Description(@"Methods used to authenticate a person or a card.")]
[DerivedFrom(typeof(AuthenticationMethodCode))]
public enum AuthenticationMethod6Code
{
    /// <summary>
    /// On-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as "NPIN".
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_pNmhAYIJEeS7UOLM47txvA")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    OnLinePIN = AuthenticationMethodCode.OnLinePIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Handwritten paper signature.
    /// Encoded/decoded by serializers as "PPSG".
    /// </summary>
    [EnumMember(Value = "PPSG")]
    [IsoId("_pNmhA4IJEeS7UOLM47txvA")]
    [Description(@"Handwritten paper signature.")]
    PaperSignature = AuthenticationMethodCode.PaperSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication by a password.
    /// Encoded/decoded by serializers as "PSWD".
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_pNmhBYIJEeS7UOLM47txvA")]
    [Description(@"Authentication by a password.")]
    Password = AuthenticationMethodCode.Password, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Electronic commerce transaction secured with the X.509 certificate of a customer.
    /// Encoded/decoded by serializers as "SCRT".
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_pNmhB4IJEeS7UOLM47txvA")]
    [Description(@"Electronic commerce transaction secured with the X.509 certificate of a customer.")]
    SecureCertificate = AuthenticationMethodCode.SecureCertificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Channel-encrypted transaction.
    /// Encoded/decoded by serializers as "SCNL".
    /// </summary>
    [EnumMember(Value = "SCNL")]
    [IsoId("_pNmhCYIJEeS7UOLM47txvA")]
    [Description(@"Channel-encrypted transaction.")]
    SecuredChannel = AuthenticationMethodCode.SecuredChannel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Secure electronic transaction without cardholder certificate.
    /// Encoded/decoded by serializers as "SNCT".
    /// </summary>
    [EnumMember(Value = "SNCT")]
    [IsoId("_pNmhC4IJEeS7UOLM47txvA")]
    [Description(@"Secure electronic transaction without cardholder certificate.")]
    SecureNoCertificate = AuthenticationMethodCode.SecureNoCertificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Electronic signature capture (handwritten signature).
    /// Encoded/decoded by serializers as "CPSG".
    /// </summary>
    [EnumMember(Value = "CPSG")]
    [IsoId("_pNmhDYIJEeS7UOLM47txvA")]
    [Description(@"Electronic signature capture (handwritten signature).")]
    SignatureCapture = AuthenticationMethodCode.SignatureCapture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder billing address verification.
    /// Encoded/decoded by serializers as "ADDB".
    /// </summary>
    [EnumMember(Value = "ADDB")]
    [IsoId("_pNmhD4IJEeS7UOLM47txvA")]
    [Description(@"Cardholder billing address verification.")]
    BillingAddressVerification = AuthenticationMethodCode.BillingAddressVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Biometric authentication of the cardholder.
    /// Encoded/decoded by serializers as "BIOM".
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_pNmhEYIJEeS7UOLM47txvA")]
    [Description(@"Biometric authentication of the cardholder.")]
    Biometry = AuthenticationMethodCode.Biometry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder data provided for verification, for instance social security number, driver license number, passport number.
    /// Encoded/decoded by serializers as "CDHI".
    /// </summary>
    [EnumMember(Value = "CDHI")]
    [IsoId("_pNmhE4IJEeS7UOLM47txvA")]
    [Description(@"Cardholder data provided for verification, for instance social security number, driver license number, passport number.")]
    CardholderIdentificationData = AuthenticationMethodCode.CardholderIdentificationData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as "CRYP".
    /// </summary>
    [EnumMember(Value = "CRYP")]
    [IsoId("_pNmhFYIJEeS7UOLM47txvA")]
    [Description(@"Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).")]
    CryptogramVerification = AuthenticationMethodCode.CryptogramVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification of Card Security Code.
    /// Encoded/decoded by serializers as "CSCV".
    /// </summary>
    [EnumMember(Value = "CSCV")]
    [IsoId("_pNmhF4IJEeS7UOLM47txvA")]
    [Description(@"Verification of Card Security Code.")]
    CSCVerification = AuthenticationMethodCode.CSCVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication based on statistical cardholder behaviour.
    /// Encoded/decoded by serializers as "PSVE".
    /// </summary>
    [EnumMember(Value = "PSVE")]
    [IsoId("_pNmhGYIJEeS7UOLM47txvA")]
    [Description(@"Authentication based on statistical cardholder behaviour.")]
    PassiveAuthentication = AuthenticationMethodCode.PassiveAuthentication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as "CSEC".
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_pNmhG4IJEeS7UOLM47txvA")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    SecureElectronicCommerce = AuthenticationMethodCode.SecureElectronicCommerce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder shipping address verification.
    /// Encoded/decoded by serializers as "ADDS".
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_pNmhHYIJEeS7UOLM47txvA")]
    [Description(@"Cardholder shipping address verification.")]
    ShippingAddressVerification = AuthenticationMethodCode.ShippingAddressVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as "MANU".
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_pNmhIYIJEeS7UOLM47txvA")]
    [Description(@"Manual verification, for example passport or drivers license.")]
    ManualVerification = AuthenticationMethodCode.ManualVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Off-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as "FPIN".
    /// </summary>
    [EnumMember(Value = "FPIN")]
    [IsoId("_pNmhI4IJEeS7UOLM47txvA")]
    [Description(@"Off-line PIN authentication (Personal Identification Number).")]
    OfflinePIN = AuthenticationMethodCode.OfflinePIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.
    /// Encoded/decoded by serializers as "TOKP".
    /// </summary>
    [EnumMember(Value = "TOKP")]
    [IsoId("_saMY0YIJEeS7UOLM47txvA")]
    [Description(@"Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.")]
    PaymentToken = AuthenticationMethodCode.PaymentToken, // same ordinal as derivation source for type conversions
    
}
