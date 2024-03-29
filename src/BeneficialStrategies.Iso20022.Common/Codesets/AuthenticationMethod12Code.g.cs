﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthenticationMethod12Code.  ISO2002 ID# _N1RIgcVTEeuPIIgba4mCug.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of authentication method.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_N1RIgcVTEeuPIIgba4mCug")]
[Description(@"Type of authentication method.")]
[DerivedFrom(typeof(AuthenticationMethodCode))]
public enum AuthenticationMethod12Code
{
    /// <summary>
    /// Account-based digital signature authentication.
    /// Encoded/decoded by serializers as &quot;APKI&quot;.
    /// </summary>
    [EnumMember(Value = "APKI")]
    [IsoId("_N6_WAcVTEeuPIIgba4mCug")]
    [Description(@"Account-based digital signature authentication.")]
    AccountDigitalSignature = AuthenticationMethodCode.AccountDigitalSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Digits of the address.
    /// Encoded/decoded by serializers as &quot;ADVF&quot;.
    /// </summary>
    [EnumMember(Value = "ADVF")]
    [IsoId("_N6_WA8VTEeuPIIgba4mCug")]
    [Description(@"Digits of the address.")]
    AddressDigits = AuthenticationMethodCode.AddressDigits, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;ARNB&quot;.
    /// </summary>
    [EnumMember(Value = "ARNB")]
    [IsoId("_N6_WBcVTEeuPIIgba4mCug")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber = AuthenticationMethodCode.AlienRegistrationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response Card Cryptogram (ARPC)  verification.
    /// Encoded/decoded by serializers as &quot;ARPC&quot;.
    /// </summary>
    [EnumMember(Value = "ARPC")]
    [IsoId("_N6_WB8VTEeuPIIgba4mCug")]
    [Description(@"Response Card Cryptogram (ARPC)  verification.")]
    ARPCVerification = AuthenticationMethodCode.ARPCVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification of a cryptogram generated by a chip card, for instance an ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as &quot;ARQC&quot;.
    /// </summary>
    [EnumMember(Value = "ARQC")]
    [IsoId("_N6_WCcVTEeuPIIgba4mCug")]
    [Description(@"Verification of a cryptogram generated by a chip card, for instance an ARQC (Authorisation Request Cryptogram).")]
    ARQCVerification = AuthenticationMethodCode.ARQCVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Application Transaction Counter
    /// Encoded/decoded by serializers as &quot;ATCC&quot;.
    /// </summary>
    [EnumMember(Value = "ATCC")]
    [IsoId("_N6_WC8VTEeuPIIgba4mCug")]
    [Description(@"Application Transaction Counter")]
    ATC = AuthenticationMethodCode.ATC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Date of birth of a person.
    /// Encoded/decoded by serializers as &quot;BTHD&quot;.
    /// </summary>
    [EnumMember(Value = "BTHD")]
    [IsoId("_N6_WDcVTEeuPIIgba4mCug")]
    [Description(@"Date of birth of a person.")]
    BirthDate = AuthenticationMethodCode.BirthDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification whether the address corresponds to the cardholder&apos;s one.
    /// Encoded/decoded by serializers as &quot;CHSA&quot;.
    /// </summary>
    [EnumMember(Value = "CHSA")]
    [IsoId("_N6_WD8VTEeuPIIgba4mCug")]
    [Description(@"Verification whether the address corresponds to the cardholder's one.")]
    CardholderAddress = AuthenticationMethodCode.CardholderAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name of cardholder
    /// Encoded/decoded by serializers as &quot;CHDN&quot;.
    /// </summary>
    [EnumMember(Value = "CHDN")]
    [IsoId("_N6_WEcVTEeuPIIgba4mCug")]
    [Description(@"Name of cardholder")]
    CardholderName = AuthenticationMethodCode.CardholderName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer number used as a mechanism of authentication.
    /// Encoded/decoded by serializers as &quot;CUID&quot;.
    /// </summary>
    [EnumMember(Value = "CUID")]
    [IsoId("_N6_WE8VTEeuPIIgba4mCug")]
    [Description(@"Customer number used as a mechanism of authentication.")]
    CustomerIdentification = AuthenticationMethodCode.CustomerIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of a driver in a fleet of vehicles.
    /// Encoded/decoded by serializers as &quot;DRVI&quot;.
    /// </summary>
    [EnumMember(Value = "DRVI")]
    [IsoId("_N6_WFcVTEeuPIIgba4mCug")]
    [Description(@"Identification of a driver in a fleet of vehicles.")]
    DriverIdentification = AuthenticationMethodCode.DriverIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a driving license authority to a person driving a car.
    /// Encoded/decoded by serializers as &quot;DRLN&quot;.
    /// </summary>
    [EnumMember(Value = "DRLN")]
    [IsoId("_N6_WF8VTEeuPIIgba4mCug")]
    [Description(@"Number assigned by a driving license authority to a person driving a car.")]
    DriverLicenseNumber = AuthenticationMethodCode.DriverLicenseNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Electronic mail address
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_N6_WGcVTEeuPIIgba4mCug")]
    [Description(@"Electronic mail address")]
    Email = AuthenticationMethodCode.Email, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned to an employee by an employer.
    /// Encoded/decoded by serializers as &quot;EMIN&quot;.
    /// </summary>
    [EnumMember(Value = "EMIN")]
    [IsoId("_N6_WG8VTEeuPIIgba4mCug")]
    [Description(@"Number assigned to an employee by an employer.")]
    EmployeeIdentificationNumber = AuthenticationMethodCode.EmployeeIdentificationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// Encoded/decoded by serializers as &quot;EMRN&quot;.
    /// </summary>
    [EnumMember(Value = "EMRN")]
    [IsoId("_N6_WHcVTEeuPIIgba4mCug")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    EmployerIdentificationNumber = AuthenticationMethodCode.EmployerIdentificationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as &quot;IDCN&quot;.
    /// </summary>
    [EnumMember(Value = "IDCN")]
    [IsoId("_N6_WH8VTEeuPIIgba4mCug")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber = AuthenticationMethodCode.IdentityCardNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as &quot;MANU&quot;.
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_N6_WIcVTEeuPIIgba4mCug")]
    [Description(@"Manual verification, for example passport or drivers license.")]
    ManualVerification = AuthenticationMethodCode.ManualVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Non visible Card Security Code.
    /// Encoded/decoded by serializers as &quot;NVSC&quot;.
    /// </summary>
    [EnumMember(Value = "NVSC")]
    [IsoId("_N6_WI8VTEeuPIIgba4mCug")]
    [Description(@"Non visible Card Security Code.")]
    NonVisibleCSC = AuthenticationMethodCode.NonVisibleCSC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Biographics authentication in an offline mode.
    /// Encoded/decoded by serializers as &quot;FBIG&quot;.
    /// </summary>
    [EnumMember(Value = "FBIG")]
    [IsoId("_N6_WJcVTEeuPIIgba4mCug")]
    [Description(@"Biographics authentication in an offline mode.")]
    OffLineBiographics = AuthenticationMethodCode.OffLineBiographics, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Biometrics authentication in an offline mode
    /// Encoded/decoded by serializers as &quot;FBIO&quot;.
    /// </summary>
    [EnumMember(Value = "FBIO")]
    [IsoId("_N6_WJ8VTEeuPIIgba4mCug")]
    [Description(@"Biometrics authentication in an offline mode")]
    OffLineBiometrics = AuthenticationMethodCode.OffLineBiometrics, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication of data in an offline mode
    /// Encoded/decoded by serializers as &quot;OLDA&quot;.
    /// </summary>
    [EnumMember(Value = "OLDA")]
    [IsoId("_N6_WKcVTEeuPIIgba4mCug")]
    [Description(@"Authentication of data in an offline mode")]
    OffLineDataAuthentication = AuthenticationMethodCode.OffLineDataAuthentication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Analysis of signature transmitted offline
    /// Encoded/decoded by serializers as &quot;OLDS&quot;.
    /// </summary>
    [EnumMember(Value = "OLDS")]
    [IsoId("_N6_WK8VTEeuPIIgba4mCug")]
    [Description(@"Analysis of signature transmitted offline")]
    OffLineDigitisedSignatureAnalysis = AuthenticationMethodCode.OffLineDigitisedSignatureAnalysis, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN generated offline and transmitted encrypted
    /// Encoded/decoded by serializers as &quot;OFPE&quot;.
    /// </summary>
    [EnumMember(Value = "OFPE")]
    [IsoId("_N6_WLcVTEeuPIIgba4mCug")]
    [Description(@"PIN generated offline and transmitted encrypted")]
    OffLinePINEncrypted = AuthenticationMethodCode.OffLinePINEncrypted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN generated offline and transmitted in clear
    /// Encoded/decoded by serializers as &quot;FCPN&quot;.
    /// </summary>
    [EnumMember(Value = "FCPN")]
    [IsoId("_N6_WL8VTEeuPIIgba4mCug")]
    [Description(@"PIN generated offline and transmitted in clear")]
    OffLinePINInClear = AuthenticationMethodCode.OffLinePINInClear, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification of a one-time password provided by the issuer.
    /// Encoded/decoded by serializers as &quot;OTPW&quot;.
    /// </summary>
    [EnumMember(Value = "OTPW")]
    [IsoId("_N6_WMcVTEeuPIIgba4mCug")]
    [Description(@"Verification of a one-time password provided by the issuer.")]
    OneTimePassword = AuthenticationMethodCode.OneTimePassword, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Biographics authentication in an online mode.
    /// Encoded/decoded by serializers as &quot;NBIG&quot;.
    /// </summary>
    [EnumMember(Value = "NBIG")]
    [IsoId("_N6_WM8VTEeuPIIgba4mCug")]
    [Description(@"Biographics authentication in an online mode.")]
    OnLineBiographics = AuthenticationMethodCode.OnLineBiographics, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// On-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;NPIN&quot;.
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_N6_WNcVTEeuPIIgba4mCug")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    OnLinePIN = AuthenticationMethodCode.OnLinePIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other cardholder data provided for identification.
    /// Encoded/decoded by serializers as &quot;OCHI&quot;.
    /// </summary>
    [EnumMember(Value = "OCHI")]
    [IsoId("_N6_WN8VTEeuPIIgba4mCug")]
    [Description(@"Other cardholder data provided for identification.")]
    OtherCardholderIdentification = AuthenticationMethodCode.OtherCardholderIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of verification defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_N6_WOcVTEeuPIIgba4mCug")]
    [Description(@"Other type of verification defined at national level.")]
    OtherNational = AuthenticationMethodCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of verification defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_N6_9EcVTEeuPIIgba4mCug")]
    [Description(@"Other type of verification defined at private level")]
    OtherPrivate = AuthenticationMethodCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Handwritten paper signature.
    /// Encoded/decoded by serializers as &quot;PPSG&quot;.
    /// </summary>
    [EnumMember(Value = "PPSG")]
    [IsoId("_N6_9E8VTEeuPIIgba4mCug")]
    [Description(@"Handwritten paper signature.")]
    PaperSignature = AuthenticationMethodCode.PaperSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication based on statistical cardholder behaviour.
    /// Encoded/decoded by serializers as &quot;PSVE&quot;.
    /// </summary>
    [EnumMember(Value = "PSVE")]
    [IsoId("_N6_9FcVTEeuPIIgba4mCug")]
    [Description(@"Authentication based on statistical cardholder behaviour.")]
    PassiveAuthentication = AuthenticationMethodCode.PassiveAuthentication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as &quot;PASN&quot;.
    /// </summary>
    [EnumMember(Value = "PASN")]
    [IsoId("_N6_9F8VTEeuPIIgba4mCug")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber = AuthenticationMethodCode.PassportNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication by a password.
    /// Encoded/decoded by serializers as &quot;PSWD&quot;.
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_N6_9GcVTEeuPIIgba4mCug")]
    [Description(@"Authentication by a password.")]
    Password = AuthenticationMethodCode.Password, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.
    /// Encoded/decoded by serializers as &quot;TOKP&quot;.
    /// </summary>
    [EnumMember(Value = "TOKP")]
    [IsoId("_N6_9G8VTEeuPIIgba4mCug")]
    [Description(@"Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.")]
    PaymentToken = AuthenticationMethodCode.PaymentToken, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PKI (Public Key Infrastructure) based digital signature
    /// Encoded/decoded by serializers as &quot;PKIS&quot;.
    /// </summary>
    [EnumMember(Value = "PKIS")]
    [IsoId("_N6_9HcVTEeuPIIgba4mCug")]
    [Description(@"PKI (Public Key Infrastructure) based digital signature")]
    PKISignature = AuthenticationMethodCode.PKISignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Place of birth of a person.
    /// Encoded/decoded by serializers as &quot;PLOB&quot;.
    /// </summary>
    [EnumMember(Value = "PLOB")]
    [IsoId("_N6_9H8VTEeuPIIgba4mCug")]
    [Description(@"Place of birth of a person.")]
    PlaceOfBirth = AuthenticationMethodCode.PlaceOfBirth, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification based on digits of the postal code.
    /// Encoded/decoded by serializers as &quot;PCDV&quot;.
    /// </summary>
    [EnumMember(Value = "PCDV")]
    [IsoId("_N6_9IcVTEeuPIIgba4mCug")]
    [Description(@"Verification based on digits of the postal code.")]
    PostalCode = AuthenticationMethodCode.PostalCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Electronic commerce transaction secured with the X.509 certificate of a customer.
    /// Encoded/decoded by serializers as &quot;SCRT&quot;.
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_N6_9I8VTEeuPIIgba4mCug")]
    [Description(@"Electronic commerce transaction secured with the X.509 certificate of a customer.")]
    SecureCertificate = AuthenticationMethodCode.SecureCertificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Channel-encrypted transaction.
    /// Encoded/decoded by serializers as &quot;SCNL&quot;.
    /// </summary>
    [EnumMember(Value = "SCNL")]
    [IsoId("_N6_9JcVTEeuPIIgba4mCug")]
    [Description(@"Channel-encrypted transaction.")]
    SecuredChannel = AuthenticationMethodCode.SecuredChannel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as &quot;CSEC&quot;.
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_N6_9J8VTEeuPIIgba4mCug")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    SecureElectronicCommerce = AuthenticationMethodCode.SecureElectronicCommerce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Shipping address from verification.
    /// Encoded/decoded by serializers as &quot;SHAF&quot;.
    /// </summary>
    [EnumMember(Value = "SHAF")]
    [IsoId("_N6_9KcVTEeuPIIgba4mCug")]
    [Description(@"Shipping address from verification.")]
    ShippingAddressFrom = AuthenticationMethodCode.ShippingAddressFrom, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Shipping address to verification
    /// Encoded/decoded by serializers as &quot;SHAT&quot;.
    /// </summary>
    [EnumMember(Value = "SHAT")]
    [IsoId("_N6_9K8VTEeuPIIgba4mCug")]
    [Description(@"Shipping address to verification")]
    ShippingAddressTo = AuthenticationMethodCode.ShippingAddressTo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Electronic signature capture (handwritten signature).
    /// Encoded/decoded by serializers as &quot;CPSG&quot;.
    /// </summary>
    [EnumMember(Value = "CPSG")]
    [IsoId("_N6_9LcVTEeuPIIgba4mCug")]
    [Description(@"Electronic signature capture (handwritten signature).")]
    SignatureCapture = AuthenticationMethodCode.SignatureCapture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as &quot;SSNB&quot;.
    /// </summary>
    [EnumMember(Value = "SSNB")]
    [IsoId("_N6_9L8VTEeuPIIgba4mCug")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber = AuthenticationMethodCode.SocialSecurityNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// Encoded/decoded by serializers as &quot;TXIN&quot;.
    /// </summary>
    [EnumMember(Value = "TXIN")]
    [IsoId("_N6_9McVTEeuPIIgba4mCug")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    TaxIdentificationNumber = AuthenticationMethodCode.TaxIdentificationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A token is used to verify an already performed authentication.
    /// Encoded/decoded by serializers as &quot;TOKA&quot;.
    /// </summary>
    [EnumMember(Value = "TOKA")]
    [IsoId("_N6_9M8VTEeuPIIgba4mCug")]
    [Description(@"A token is used to verify an already performed authentication.")]
    AuthenticationToken = AuthenticationMethodCode.AuthenticationToken, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder data provided for verification, for instance social security number, driver license number, passport number.
    /// Encoded/decoded by serializers as &quot;CDHI&quot;.
    /// </summary>
    [EnumMember(Value = "CDHI")]
    [IsoId("_N6_9NcVTEeuPIIgba4mCug")]
    [Description(@"Cardholder data provided for verification, for instance social security number, driver license number, passport number.")]
    CardholderIdentificationData = AuthenticationMethodCode.CardholderIdentificationData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_N6_9N8VTEeuPIIgba4mCug")]
    [Description(@"Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.")]
    TokenAuthentication = AuthenticationMethodCode.TokenAuthentication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// QualifiedCertificate
    /// Encoded/decoded by serializers as &quot;QWAC&quot;.
    /// </summary>
    [EnumMember(Value = "QWAC")]
    [IsoId("_N6_9OcVTEeuPIIgba4mCug")]
    [Description(@"QualifiedCertificate")]
    QualifiedCertificate = AuthenticationMethodCode.QualifiedCertificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer home phone number.
    /// Encoded/decoded by serializers as &quot;PHOM&quot;.
    /// </summary>
    [EnumMember(Value = "PHOM")]
    [IsoId("_N6_9O8VTEeuPIIgba4mCug")]
    [Description(@"Customer home phone number.")]
    PhoneHome = AuthenticationMethodCode.PhoneHome, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer work phone number
    /// Encoded/decoded by serializers as &quot;PWOR&quot;.
    /// </summary>
    [EnumMember(Value = "PWOR")]
    [IsoId("_N6_9PcVTEeuPIIgba4mCug")]
    [Description(@"Customer work phone number")]
    PhoneWork = AuthenticationMethodCode.PhoneWork, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as &quot;THDS&quot;.
    /// </summary>
    [EnumMember(Value = "THDS")]
    [IsoId("_N6_9P8VTEeuPIIgba4mCug")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    ThreeDS = AuthenticationMethodCode.ThreeDS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder billing address verification.
    /// Encoded/decoded by serializers as &quot;ADDB&quot;.
    /// </summary>
    [EnumMember(Value = "ADDB")]
    [IsoId("_N6_9QcVTEeuPIIgba4mCug")]
    [Description(@"Cardholder billing address verification.")]
    BillingAddressVerification = AuthenticationMethodCode.BillingAddressVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder shipping address verification.
    /// Encoded/decoded by serializers as &quot;ADDS&quot;.
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_N6_9Q8VTEeuPIIgba4mCug")]
    [Description(@"Cardholder shipping address verification.")]
    ShippingAddressVerification = AuthenticationMethodCode.ShippingAddressVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification of Card Security Code.
    /// Encoded/decoded by serializers as &quot;CSCV&quot;.
    /// </summary>
    [EnumMember(Value = "CSCV")]
    [IsoId("_N6_9RcVTEeuPIIgba4mCug")]
    [Description(@"Verification of Card Security Code.")]
    CSCVerification = AuthenticationMethodCode.CSCVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as &quot;CRYP&quot;.
    /// </summary>
    [EnumMember(Value = "CRYP")]
    [IsoId("_N6_9R8VTEeuPIIgba4mCug")]
    [Description(@"Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).")]
    CryptogramVerification = AuthenticationMethodCode.CryptogramVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Biometric authentication of the cardholder.
    /// Encoded/decoded by serializers as &quot;BIOM&quot;.
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_N6_9ScVTEeuPIIgba4mCug")]
    [Description(@"Biometric authentication of the cardholder.")]
    Biometry = AuthenticationMethodCode.Biometry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer mobile device.
    /// Encoded/decoded by serializers as &quot;MOBL&quot;.
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_N6_9S8VTEeuPIIgba4mCug")]
    [Description(@"Customer mobile device.")]
    Mobile = AuthenticationMethodCode.Mobile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Off-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FPIN&quot;.
    /// </summary>
    [EnumMember(Value = "FPIN")]
    [IsoId("_N6_9TcVTEeuPIIgba4mCug")]
    [Description(@"Off-line PIN authentication (Personal Identification Number).")]
    OfflinePIN = AuthenticationMethodCode.OfflinePIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Nationally assigned identifier.
    /// Encoded/decoded by serializers as &quot;NTID&quot;.
    /// </summary>
    [EnumMember(Value = "NTID")]
    [IsoId("_Ub_vccVUEeuPIIgba4mCug")]
    [Description(@"Nationally assigned identifier.")]
    NationalIdentifier = AuthenticationMethodCode.NationalIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Serial number of the acceptor&apos;s certificate.
    /// Encoded/decoded by serializers as &quot;ACSN&quot;.
    /// </summary>
    [EnumMember(Value = "ACSN")]
    [IsoId("_VkhdwcVUEeuPIIgba4mCug")]
    [Description(@"Serial number of the acceptor's certificate.")]
    AcceptorCertificateSerialNumber = AuthenticationMethodCode.AcceptorCertificateSerialNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Serial number of the cardholder&apos;s certificate.
    /// Encoded/decoded by serializers as &quot;CHSN&quot;.
    /// </summary>
    [EnumMember(Value = "CHSN")]
    [IsoId("_WPDogcVUEeuPIIgba4mCug")]
    [Description(@"Serial number of the cardholder's certificate.")]
    CardholderCertificateSerialNumber = AuthenticationMethodCode.CardholderCertificateSerialNumber, // same ordinal as derivation source for type conversions
    
}
