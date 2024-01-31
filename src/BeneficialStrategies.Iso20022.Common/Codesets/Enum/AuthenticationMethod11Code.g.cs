﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthenticationMethod11Code.  ISO2002 ID# _jQxm0FjnEeiTlKUpxxSxEw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of authentication method.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jQxm0FjnEeiTlKUpxxSxEw")]
[Description(@"Type of authentication method.")]
[DerivedFrom(typeof(AuthenticationMethodCode))]
public enum AuthenticationMethod11Code
{
    /// <summary>
    /// Account-based digital signature authentication.
    /// Encoded/decoded by serializers as "APKI".
    /// </summary>
    [EnumMember(Value = "APKI")]
    [IsoId("_gxrYIX0kEemfrNOe0zHQyg")]
    [Description(@"Account-based digital signature authentication.")]
    AccountDigitalSignature = AuthenticationMethodCode.AccountDigitalSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Digits of the address.
    /// Encoded/decoded by serializers as "ADVF".
    /// </summary>
    [EnumMember(Value = "ADVF")]
    [IsoId("_gxrYI30kEemfrNOe0zHQyg")]
    [Description(@"Digits of the address.")]
    AddressDigits = AuthenticationMethodCode.AddressDigits, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as "ARNB".
    /// </summary>
    [EnumMember(Value = "ARNB")]
    [IsoId("_gxrYJX0kEemfrNOe0zHQyg")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber = AuthenticationMethodCode.AlienRegistrationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response Card Cryptogram (ARPC)  verification.
    /// Encoded/decoded by serializers as "ARPC".
    /// </summary>
    [EnumMember(Value = "ARPC")]
    [IsoId("_gxrYJ30kEemfrNOe0zHQyg")]
    [Description(@"Response Card Cryptogram (ARPC)  verification.")]
    ARPCVerification = AuthenticationMethodCode.ARPCVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification of a cryptogram generated by a chip card, for instance an ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as "ARQC".
    /// </summary>
    [EnumMember(Value = "ARQC")]
    [IsoId("_gxrYKX0kEemfrNOe0zHQyg")]
    [Description(@"Verification of a cryptogram generated by a chip card, for instance an ARQC (Authorisation Request Cryptogram).")]
    ARQCVerification = AuthenticationMethodCode.ARQCVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Application Transaction Counter
    /// Encoded/decoded by serializers as "ATCC".
    /// </summary>
    [EnumMember(Value = "ATCC")]
    [IsoId("_gxrYK30kEemfrNOe0zHQyg")]
    [Description(@"Application Transaction Counter")]
    ATC = AuthenticationMethodCode.ATC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Date of birth of a person.
    /// Encoded/decoded by serializers as "BTHD".
    /// </summary>
    [EnumMember(Value = "BTHD")]
    [IsoId("_gxrYLX0kEemfrNOe0zHQyg")]
    [Description(@"Date of birth of a person.")]
    BirthDate = AuthenticationMethodCode.BirthDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification whether the address corresponds to the cardholder's one.
    /// Encoded/decoded by serializers as "CHSA".
    /// </summary>
    [EnumMember(Value = "CHSA")]
    [IsoId("_gxrYL30kEemfrNOe0zHQyg")]
    [Description(@"Verification whether the address corresponds to the cardholder's one.")]
    CardholderAddress = AuthenticationMethodCode.CardholderAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name of cardholder
    /// Encoded/decoded by serializers as "CHDN".
    /// </summary>
    [EnumMember(Value = "CHDN")]
    [IsoId("_gxrYMX0kEemfrNOe0zHQyg")]
    [Description(@"Name of cardholder")]
    CardholderName = AuthenticationMethodCode.CardholderName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer number used as a mechanism of authentication.
    /// Encoded/decoded by serializers as "CUID".
    /// </summary>
    [EnumMember(Value = "CUID")]
    [IsoId("_gxrYM30kEemfrNOe0zHQyg")]
    [Description(@"Customer number used as a mechanism of authentication.")]
    CustomerIdentification = AuthenticationMethodCode.CustomerIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of a driver in a fleet of vehicles.
    /// Encoded/decoded by serializers as "DRVI".
    /// </summary>
    [EnumMember(Value = "DRVI")]
    [IsoId("_gxrYNX0kEemfrNOe0zHQyg")]
    [Description(@"Identification of a driver in a fleet of vehicles.")]
    DriverIdentification = AuthenticationMethodCode.DriverIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a driving license authority to a person driving a car.
    /// Encoded/decoded by serializers as "DRLN".
    /// </summary>
    [EnumMember(Value = "DRLN")]
    [IsoId("_gxrYN30kEemfrNOe0zHQyg")]
    [Description(@"Number assigned by a driving license authority to a person driving a car.")]
    DriverLicenseNumber = AuthenticationMethodCode.DriverLicenseNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Electronic mail address
    /// Encoded/decoded by serializers as "EMAL".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_gxrYOX0kEemfrNOe0zHQyg")]
    [Description(@"Electronic mail address")]
    Email = AuthenticationMethodCode.Email, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned to an employee by an employer.
    /// Encoded/decoded by serializers as "EMIN".
    /// </summary>
    [EnumMember(Value = "EMIN")]
    [IsoId("_gxrYO30kEemfrNOe0zHQyg")]
    [Description(@"Number assigned to an employee by an employer.")]
    EmployeeIdentificationNumber = AuthenticationMethodCode.EmployeeIdentificationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// Encoded/decoded by serializers as "EMRN".
    /// </summary>
    [EnumMember(Value = "EMRN")]
    [IsoId("_gxrYPX0kEemfrNOe0zHQyg")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    EmployerIdentificationNumber = AuthenticationMethodCode.EmployerIdentificationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as "IDCN".
    /// </summary>
    [EnumMember(Value = "IDCN")]
    [IsoId("_gxrYP30kEemfrNOe0zHQyg")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber = AuthenticationMethodCode.IdentityCardNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as "MANU".
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_gxrYQX0kEemfrNOe0zHQyg")]
    [Description(@"Manual verification, for example passport or drivers license.")]
    ManualVerification = AuthenticationMethodCode.ManualVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Non visible Card Security Code.
    /// Encoded/decoded by serializers as "NVSC".
    /// </summary>
    [EnumMember(Value = "NVSC")]
    [IsoId("_gxrYQ30kEemfrNOe0zHQyg")]
    [Description(@"Non visible Card Security Code.")]
    NonVisibleCSC = AuthenticationMethodCode.NonVisibleCSC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Biographics authentication in an offline mode.
    /// Encoded/decoded by serializers as "FBIG".
    /// </summary>
    [EnumMember(Value = "FBIG")]
    [IsoId("_gxrYRX0kEemfrNOe0zHQyg")]
    [Description(@"Biographics authentication in an offline mode.")]
    OffLineBiographics = AuthenticationMethodCode.OffLineBiographics, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Biometrics authentication in an offline mode
    /// Encoded/decoded by serializers as "FBIO".
    /// </summary>
    [EnumMember(Value = "FBIO")]
    [IsoId("_gxrYR30kEemfrNOe0zHQyg")]
    [Description(@"Biometrics authentication in an offline mode")]
    OffLineBiometrics = AuthenticationMethodCode.OffLineBiometrics, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication of data in an offline mode
    /// Encoded/decoded by serializers as "OLDA".
    /// </summary>
    [EnumMember(Value = "OLDA")]
    [IsoId("_gxrYSX0kEemfrNOe0zHQyg")]
    [Description(@"Authentication of data in an offline mode")]
    OffLineDataAuthentication = AuthenticationMethodCode.OffLineDataAuthentication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Analysis of signature transmitted offline
    /// Encoded/decoded by serializers as "OLDS".
    /// </summary>
    [EnumMember(Value = "OLDS")]
    [IsoId("_gxrYS30kEemfrNOe0zHQyg")]
    [Description(@"Analysis of signature transmitted offline")]
    OffLineDigitisedSignatureAnalysis = AuthenticationMethodCode.OffLineDigitisedSignatureAnalysis, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN generated offline and transmitted encrypted
    /// Encoded/decoded by serializers as "OFPE".
    /// </summary>
    [EnumMember(Value = "OFPE")]
    [IsoId("_gxrYTX0kEemfrNOe0zHQyg")]
    [Description(@"PIN generated offline and transmitted encrypted")]
    OffLinePINEncrypted = AuthenticationMethodCode.OffLinePINEncrypted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN generated offline and transmitted in clear
    /// Encoded/decoded by serializers as "FCPN".
    /// </summary>
    [EnumMember(Value = "FCPN")]
    [IsoId("_gxrYT30kEemfrNOe0zHQyg")]
    [Description(@"PIN generated offline and transmitted in clear")]
    OffLinePINInClear = AuthenticationMethodCode.OffLinePINInClear, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification of a one-time password provided by the issuer.
    /// Encoded/decoded by serializers as "OTPW".
    /// </summary>
    [EnumMember(Value = "OTPW")]
    [IsoId("_gxrYUX0kEemfrNOe0zHQyg")]
    [Description(@"Verification of a one-time password provided by the issuer.")]
    OneTimePassword = AuthenticationMethodCode.OneTimePassword, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Biographics authentication in an online mode.
    /// Encoded/decoded by serializers as "NBIG".
    /// </summary>
    [EnumMember(Value = "NBIG")]
    [IsoId("_gxrYU30kEemfrNOe0zHQyg")]
    [Description(@"Biographics authentication in an online mode.")]
    OnLineBiographics = AuthenticationMethodCode.OnLineBiographics, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// On-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as "NPIN".
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_gxrYVX0kEemfrNOe0zHQyg")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    OnLinePIN = AuthenticationMethodCode.OnLinePIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other cardholder data provided for identification.
    /// Encoded/decoded by serializers as "OCHI".
    /// </summary>
    [EnumMember(Value = "OCHI")]
    [IsoId("_gxrYV30kEemfrNOe0zHQyg")]
    [Description(@"Other cardholder data provided for identification.")]
    OtherCardholderIdentification = AuthenticationMethodCode.OtherCardholderIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of verification defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_gxrYWX0kEemfrNOe0zHQyg")]
    [Description(@"Other type of verification defined at national level.")]
    OtherNational = AuthenticationMethodCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of verification defined at private level
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_gxrYW30kEemfrNOe0zHQyg")]
    [Description(@"Other type of verification defined at private level")]
    OtherPrivate = AuthenticationMethodCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Handwritten paper signature.
    /// Encoded/decoded by serializers as "PPSG".
    /// </summary>
    [EnumMember(Value = "PPSG")]
    [IsoId("_gxrYXX0kEemfrNOe0zHQyg")]
    [Description(@"Handwritten paper signature.")]
    PaperSignature = AuthenticationMethodCode.PaperSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication based on statistical cardholder behaviour.
    /// Encoded/decoded by serializers as "PSVE".
    /// </summary>
    [EnumMember(Value = "PSVE")]
    [IsoId("_gxrYX30kEemfrNOe0zHQyg")]
    [Description(@"Authentication based on statistical cardholder behaviour.")]
    PassiveAuthentication = AuthenticationMethodCode.PassiveAuthentication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as "PASN".
    /// </summary>
    [EnumMember(Value = "PASN")]
    [IsoId("_gxrYYX0kEemfrNOe0zHQyg")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber = AuthenticationMethodCode.PassportNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication by a password.
    /// Encoded/decoded by serializers as "PSWD".
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_gxrYY30kEemfrNOe0zHQyg")]
    [Description(@"Authentication by a password.")]
    Password = AuthenticationMethodCode.Password, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.
    /// Encoded/decoded by serializers as "TOKP".
    /// </summary>
    [EnumMember(Value = "TOKP")]
    [IsoId("_gxrYZX0kEemfrNOe0zHQyg")]
    [Description(@"Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.")]
    PaymentToken = AuthenticationMethodCode.PaymentToken, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PKI (Public Key Infrastructure) based digital signature
    /// Encoded/decoded by serializers as "PKIS".
    /// </summary>
    [EnumMember(Value = "PKIS")]
    [IsoId("_gxrYZ30kEemfrNOe0zHQyg")]
    [Description(@"PKI (Public Key Infrastructure) based digital signature")]
    PKISignature = AuthenticationMethodCode.PKISignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Place of birth of a person.
    /// Encoded/decoded by serializers as "PLOB".
    /// </summary>
    [EnumMember(Value = "PLOB")]
    [IsoId("_gxrYaX0kEemfrNOe0zHQyg")]
    [Description(@"Place of birth of a person.")]
    PlaceOfBirth = AuthenticationMethodCode.PlaceOfBirth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification based on digits of the postal code.
    /// Encoded/decoded by serializers as "PCDV".
    /// </summary>
    [EnumMember(Value = "PCDV")]
    [IsoId("_gxrYa30kEemfrNOe0zHQyg")]
    [Description(@"Verification based on digits of the postal code.")]
    PostalCode = AuthenticationMethodCode.PostalCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Electronic commerce transaction secured with the X.509 certificate of a customer.
    /// Encoded/decoded by serializers as "SCRT".
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_gxrYbX0kEemfrNOe0zHQyg")]
    [Description(@"Electronic commerce transaction secured with the X.509 certificate of a customer.")]
    SecureCertificate = AuthenticationMethodCode.SecureCertificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Channel-encrypted transaction.
    /// Encoded/decoded by serializers as "SCNL".
    /// </summary>
    [EnumMember(Value = "SCNL")]
    [IsoId("_gxrYb30kEemfrNOe0zHQyg")]
    [Description(@"Channel-encrypted transaction.")]
    SecuredChannel = AuthenticationMethodCode.SecuredChannel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as "CSEC".
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_gxrYcX0kEemfrNOe0zHQyg")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    SecureElectronicCommerce = AuthenticationMethodCode.SecureElectronicCommerce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Shipping address from verification.
    /// Encoded/decoded by serializers as "SHAF".
    /// </summary>
    [EnumMember(Value = "SHAF")]
    [IsoId("_gxrYc30kEemfrNOe0zHQyg")]
    [Description(@"Shipping address from verification.")]
    ShippingAddressFrom = AuthenticationMethodCode.ShippingAddressFrom, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Shipping address to verification
    /// Encoded/decoded by serializers as "SHAT".
    /// </summary>
    [EnumMember(Value = "SHAT")]
    [IsoId("_gxrYdX0kEemfrNOe0zHQyg")]
    [Description(@"Shipping address to verification")]
    ShippingAddressTo = AuthenticationMethodCode.ShippingAddressTo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Electronic signature capture (handwritten signature).
    /// Encoded/decoded by serializers as "CPSG".
    /// </summary>
    [EnumMember(Value = "CPSG")]
    [IsoId("_gxrYd30kEemfrNOe0zHQyg")]
    [Description(@"Electronic signature capture (handwritten signature).")]
    SignatureCapture = AuthenticationMethodCode.SignatureCapture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as "SSNB".
    /// </summary>
    [EnumMember(Value = "SSNB")]
    [IsoId("_gxrYeX0kEemfrNOe0zHQyg")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber = AuthenticationMethodCode.SocialSecurityNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// Encoded/decoded by serializers as "TXIN".
    /// </summary>
    [EnumMember(Value = "TXIN")]
    [IsoId("_gxrYe30kEemfrNOe0zHQyg")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    TaxIdentificationNumber = AuthenticationMethodCode.TaxIdentificationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A token is used to verify an already performed authentication.
    /// Encoded/decoded by serializers as "TOKA".
    /// </summary>
    [EnumMember(Value = "TOKA")]
    [IsoId("_gxrYfX0kEemfrNOe0zHQyg")]
    [Description(@"A token is used to verify an already performed authentication.")]
    AuthenticationToken = AuthenticationMethodCode.AuthenticationToken, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder data provided for verification, for instance social security number, driver license number, passport number.
    /// Encoded/decoded by serializers as "CDHI".
    /// </summary>
    [EnumMember(Value = "CDHI")]
    [IsoId("_gxrYf30kEemfrNOe0zHQyg")]
    [Description(@"Cardholder data provided for verification, for instance social security number, driver license number, passport number.")]
    CardholderIdentificationData = AuthenticationMethodCode.CardholderIdentificationData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.
    /// Encoded/decoded by serializers as "TOKN".
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_gxrYgX0kEemfrNOe0zHQyg")]
    [Description(@"Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.")]
    TokenAuthentication = AuthenticationMethodCode.TokenAuthentication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// QualifiedCertificate
    /// Encoded/decoded by serializers as "QWAC".
    /// </summary>
    [EnumMember(Value = "QWAC")]
    [IsoId("_gxrYg30kEemfrNOe0zHQyg")]
    [Description(@"QualifiedCertificate")]
    QualifiedCertificate = AuthenticationMethodCode.QualifiedCertificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer home phone number.
    /// Encoded/decoded by serializers as "PHOM".
    /// </summary>
    [EnumMember(Value = "PHOM")]
    [IsoId("_gxrYhX0kEemfrNOe0zHQyg")]
    [Description(@"Customer home phone number.")]
    PhoneHome = AuthenticationMethodCode.PhoneHome, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer work phone number
    /// Encoded/decoded by serializers as "PWOR".
    /// </summary>
    [EnumMember(Value = "PWOR")]
    [IsoId("_gxrYh30kEemfrNOe0zHQyg")]
    [Description(@"Customer work phone number")]
    PhoneWork = AuthenticationMethodCode.PhoneWork, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as "THDS".
    /// </summary>
    [EnumMember(Value = "THDS")]
    [IsoId("_gxrYiX0kEemfrNOe0zHQyg")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    ThreeDS = AuthenticationMethodCode.ThreeDS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder billing address verification.
    /// Encoded/decoded by serializers as "ADDB".
    /// </summary>
    [EnumMember(Value = "ADDB")]
    [IsoId("_uHFi8X04Eem0U9m89kippg")]
    [Description(@"Cardholder billing address verification.")]
    BillingAddressVerification = AuthenticationMethodCode.BillingAddressVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder shipping address verification.
    /// Encoded/decoded by serializers as "ADDS".
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_v1x5YX04Eem0U9m89kippg")]
    [Description(@"Cardholder shipping address verification.")]
    ShippingAddressVerification = AuthenticationMethodCode.ShippingAddressVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification of Card Security Code.
    /// Encoded/decoded by serializers as "CSCV".
    /// </summary>
    [EnumMember(Value = "CSCV")]
    [IsoId("_xG3GwX04Eem0U9m89kippg")]
    [Description(@"Verification of Card Security Code.")]
    CSCVerification = AuthenticationMethodCode.CSCVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as "CRYP".
    /// </summary>
    [EnumMember(Value = "CRYP")]
    [IsoId("_zE3rkX04Eem0U9m89kippg")]
    [Description(@"Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).")]
    CryptogramVerification = AuthenticationMethodCode.CryptogramVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Biometric authentication of the cardholder.
    /// Encoded/decoded by serializers as "BIOM".
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_gMFLMX05Eem0U9m89kippg")]
    [Description(@"Biometric authentication of the cardholder.")]
    Biometry = AuthenticationMethodCode.Biometry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer mobile device.
    /// Encoded/decoded by serializers as "MOBL".
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_oU6TgX05Eem0U9m89kippg")]
    [Description(@"Customer mobile device.")]
    Mobile = AuthenticationMethodCode.Mobile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Off-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as "FPIN".
    /// </summary>
    [EnumMember(Value = "FPIN")]
    [IsoId("_xDLhMekTEemeDPHh-U9b6w")]
    [Description(@"Off-line PIN authentication (Personal Identification Number).")]
    OfflinePIN = AuthenticationMethodCode.OfflinePIN, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AuthenticationMethod11CodeMetadataExtensions
{
    private static readonly AuthenticationMethod11CodeDropdownSource _dropdownSource = new AuthenticationMethod11CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAuthenticationMethod11CodeDropdownRow GetMetadata(this AuthenticationMethod11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


