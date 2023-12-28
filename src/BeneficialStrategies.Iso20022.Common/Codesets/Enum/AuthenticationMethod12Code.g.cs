﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthenticationMethod12Code.  ISO2002 ID# _N1RIgcVTEeuPIIgba4mCug.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

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
    /// Encoded/decoded by serializers as "AccountDigitalSignature".
    /// </summary>
    [EnumMember(Value = "APKI")]
    [IsoId("_N6_WAcVTEeuPIIgba4mCug")]
    [Description(@"Account-based digital signature authentication.")]
    AccountDigitalSignature,
    
    /// <summary>
    /// Digits of the address.
    /// Encoded/decoded by serializers as "AddressDigits".
    /// </summary>
    [EnumMember(Value = "ADVF")]
    [IsoId("_N6_WA8VTEeuPIIgba4mCug")]
    [Description(@"Digits of the address.")]
    AddressDigits,
    
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as "AlienRegistrationNumber".
    /// </summary>
    [EnumMember(Value = "ARNB")]
    [IsoId("_N6_WBcVTEeuPIIgba4mCug")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber,
    
    /// <summary>
    /// Response Card Cryptogram (ARPC)  verification.
    /// Encoded/decoded by serializers as "ARPCVerification".
    /// </summary>
    [EnumMember(Value = "ARPC")]
    [IsoId("_N6_WB8VTEeuPIIgba4mCug")]
    [Description(@"Response Card Cryptogram (ARPC)  verification.")]
    ARPCVerification,
    
    /// <summary>
    /// Verification of a cryptogram generated by a chip card, for instance an ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as "ARQCVerification".
    /// </summary>
    [EnumMember(Value = "ARQC")]
    [IsoId("_N6_WCcVTEeuPIIgba4mCug")]
    [Description(@"Verification of a cryptogram generated by a chip card, for instance an ARQC (Authorisation Request Cryptogram).")]
    ARQCVerification,
    
    /// <summary>
    /// Application Transaction Counter
    /// Encoded/decoded by serializers as "ATC".
    /// </summary>
    [EnumMember(Value = "ATCC")]
    [IsoId("_N6_WC8VTEeuPIIgba4mCug")]
    [Description(@"Application Transaction Counter")]
    ATC,
    
    /// <summary>
    /// Date of birth of a person.
    /// Encoded/decoded by serializers as "BirthDate".
    /// </summary>
    [EnumMember(Value = "BTHD")]
    [IsoId("_N6_WDcVTEeuPIIgba4mCug")]
    [Description(@"Date of birth of a person.")]
    BirthDate,
    
    /// <summary>
    /// Verification whether the address corresponds to the cardholder's one.
    /// Encoded/decoded by serializers as "CardholderAddress".
    /// </summary>
    [EnumMember(Value = "CHSA")]
    [IsoId("_N6_WD8VTEeuPIIgba4mCug")]
    [Description(@"Verification whether the address corresponds to the cardholder's one.")]
    CardholderAddress,
    
    /// <summary>
    /// Name of cardholder
    /// Encoded/decoded by serializers as "CardholderName".
    /// </summary>
    [EnumMember(Value = "CHDN")]
    [IsoId("_N6_WEcVTEeuPIIgba4mCug")]
    [Description(@"Name of cardholder")]
    CardholderName,
    
    /// <summary>
    /// Customer number used as a mechanism of authentication.
    /// Encoded/decoded by serializers as "CustomerIdentification".
    /// </summary>
    [EnumMember(Value = "CUID")]
    [IsoId("_N6_WE8VTEeuPIIgba4mCug")]
    [Description(@"Customer number used as a mechanism of authentication.")]
    CustomerIdentification,
    
    /// <summary>
    /// Identification of a driver in a fleet of vehicles.
    /// Encoded/decoded by serializers as "DriverIdentification".
    /// </summary>
    [EnumMember(Value = "DRVI")]
    [IsoId("_N6_WFcVTEeuPIIgba4mCug")]
    [Description(@"Identification of a driver in a fleet of vehicles.")]
    DriverIdentification,
    
    /// <summary>
    /// Number assigned by a driving license authority to a person driving a car.
    /// Encoded/decoded by serializers as "DriverLicenseNumber".
    /// </summary>
    [EnumMember(Value = "DRLN")]
    [IsoId("_N6_WF8VTEeuPIIgba4mCug")]
    [Description(@"Number assigned by a driving license authority to a person driving a car.")]
    DriverLicenseNumber,
    
    /// <summary>
    /// Electronic mail address
    /// Encoded/decoded by serializers as "Email".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_N6_WGcVTEeuPIIgba4mCug")]
    [Description(@"Electronic mail address")]
    Email,
    
    /// <summary>
    /// Number assigned to an employee by an employer.
    /// Encoded/decoded by serializers as "EmployeeIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "EMIN")]
    [IsoId("_N6_WG8VTEeuPIIgba4mCug")]
    [Description(@"Number assigned to an employee by an employer.")]
    EmployeeIdentificationNumber,
    
    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// Encoded/decoded by serializers as "EmployerIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "EMRN")]
    [IsoId("_N6_WHcVTEeuPIIgba4mCug")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    EmployerIdentificationNumber,
    
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as "IdentityCardNumber".
    /// </summary>
    [EnumMember(Value = "IDCN")]
    [IsoId("_N6_WH8VTEeuPIIgba4mCug")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber,
    
    /// <summary>
    /// Manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as "ManualVerification".
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_N6_WIcVTEeuPIIgba4mCug")]
    [Description(@"Manual verification, for example passport or drivers license.")]
    ManualVerification,
    
    /// <summary>
    /// Non visible Card Security Code.
    /// Encoded/decoded by serializers as "NonVisibleCSC".
    /// </summary>
    [EnumMember(Value = "NVSC")]
    [IsoId("_N6_WI8VTEeuPIIgba4mCug")]
    [Description(@"Non visible Card Security Code.")]
    NonVisibleCSC,
    
    /// <summary>
    /// Biographics authentication in an offline mode.
    /// Encoded/decoded by serializers as "OffLineBiographics".
    /// </summary>
    [EnumMember(Value = "FBIG")]
    [IsoId("_N6_WJcVTEeuPIIgba4mCug")]
    [Description(@"Biographics authentication in an offline mode.")]
    OffLineBiographics,
    
    /// <summary>
    /// Biometrics authentication in an offline mode
    /// Encoded/decoded by serializers as "OffLineBiometrics".
    /// </summary>
    [EnumMember(Value = "FBIO")]
    [IsoId("_N6_WJ8VTEeuPIIgba4mCug")]
    [Description(@"Biometrics authentication in an offline mode")]
    OffLineBiometrics,
    
    /// <summary>
    /// Authentication of data in an offline mode
    /// Encoded/decoded by serializers as "OffLineDataAuthentication".
    /// </summary>
    [EnumMember(Value = "OLDA")]
    [IsoId("_N6_WKcVTEeuPIIgba4mCug")]
    [Description(@"Authentication of data in an offline mode")]
    OffLineDataAuthentication,
    
    /// <summary>
    /// Analysis of signature transmitted offline
    /// Encoded/decoded by serializers as "OffLineDigitisedSignatureAnalysis".
    /// </summary>
    [EnumMember(Value = "OLDS")]
    [IsoId("_N6_WK8VTEeuPIIgba4mCug")]
    [Description(@"Analysis of signature transmitted offline")]
    OffLineDigitisedSignatureAnalysis,
    
    /// <summary>
    /// PIN generated offline and transmitted encrypted
    /// Encoded/decoded by serializers as "OffLinePINEncrypted".
    /// </summary>
    [EnumMember(Value = "OFPE")]
    [IsoId("_N6_WLcVTEeuPIIgba4mCug")]
    [Description(@"PIN generated offline and transmitted encrypted")]
    OffLinePINEncrypted,
    
    /// <summary>
    /// PIN generated offline and transmitted in clear
    /// Encoded/decoded by serializers as "OffLinePINInClear".
    /// </summary>
    [EnumMember(Value = "FCPN")]
    [IsoId("_N6_WL8VTEeuPIIgba4mCug")]
    [Description(@"PIN generated offline and transmitted in clear")]
    OffLinePINInClear,
    
    /// <summary>
    /// Verification of a one-time password provided by the issuer.
    /// Encoded/decoded by serializers as "OneTimePassword".
    /// </summary>
    [EnumMember(Value = "OTPW")]
    [IsoId("_N6_WMcVTEeuPIIgba4mCug")]
    [Description(@"Verification of a one-time password provided by the issuer.")]
    OneTimePassword,
    
    /// <summary>
    /// Biographics authentication in an online mode.
    /// Encoded/decoded by serializers as "OnLineBiographics".
    /// </summary>
    [EnumMember(Value = "NBIG")]
    [IsoId("_N6_WM8VTEeuPIIgba4mCug")]
    [Description(@"Biographics authentication in an online mode.")]
    OnLineBiographics,
    
    /// <summary>
    /// On-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as "OnLinePIN".
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_N6_WNcVTEeuPIIgba4mCug")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    OnLinePIN,
    
    /// <summary>
    /// Other cardholder data provided for identification.
    /// Encoded/decoded by serializers as "OtherCardholderIdentification".
    /// </summary>
    [EnumMember(Value = "OCHI")]
    [IsoId("_N6_WN8VTEeuPIIgba4mCug")]
    [Description(@"Other cardholder data provided for identification.")]
    OtherCardholderIdentification,
    
    /// <summary>
    /// Other type of verification defined at national level.
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_N6_WOcVTEeuPIIgba4mCug")]
    [Description(@"Other type of verification defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of verification defined at private level
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_N6_9EcVTEeuPIIgba4mCug")]
    [Description(@"Other type of verification defined at private level")]
    OtherPrivate,
    
    /// <summary>
    /// Handwritten paper signature.
    /// Encoded/decoded by serializers as "PaperSignature".
    /// </summary>
    [EnumMember(Value = "PPSG")]
    [IsoId("_N6_9E8VTEeuPIIgba4mCug")]
    [Description(@"Handwritten paper signature.")]
    PaperSignature,
    
    /// <summary>
    /// Authentication based on statistical cardholder behaviour.
    /// Encoded/decoded by serializers as "PassiveAuthentication".
    /// </summary>
    [EnumMember(Value = "PSVE")]
    [IsoId("_N6_9FcVTEeuPIIgba4mCug")]
    [Description(@"Authentication based on statistical cardholder behaviour.")]
    PassiveAuthentication,
    
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as "PassportNumber".
    /// </summary>
    [EnumMember(Value = "PASN")]
    [IsoId("_N6_9F8VTEeuPIIgba4mCug")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber,
    
    /// <summary>
    /// Authentication by a password.
    /// Encoded/decoded by serializers as "Password".
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_N6_9GcVTEeuPIIgba4mCug")]
    [Description(@"Authentication by a password.")]
    Password,
    
    /// <summary>
    /// Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.
    /// Encoded/decoded by serializers as "PaymentToken".
    /// </summary>
    [EnumMember(Value = "TOKP")]
    [IsoId("_N6_9G8VTEeuPIIgba4mCug")]
    [Description(@"Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.")]
    PaymentToken,
    
    /// <summary>
    /// PKI (Public Key Infrastructure) based digital signature
    /// Encoded/decoded by serializers as "PKISignature".
    /// </summary>
    [EnumMember(Value = "PKIS")]
    [IsoId("_N6_9HcVTEeuPIIgba4mCug")]
    [Description(@"PKI (Public Key Infrastructure) based digital signature")]
    PKISignature,
    
    /// <summary>
    /// Place of birth of a person.
    /// Encoded/decoded by serializers as "PlaceOfBirth".
    /// </summary>
    [EnumMember(Value = "PLOB")]
    [IsoId("_N6_9H8VTEeuPIIgba4mCug")]
    [Description(@"Place of birth of a person.")]
    PlaceOfBirth,
    
    /// <summary>
    /// Verification based on digits of the postal code.
    /// Encoded/decoded by serializers as "PostalCode".
    /// </summary>
    [EnumMember(Value = "PCDV")]
    [IsoId("_N6_9IcVTEeuPIIgba4mCug")]
    [Description(@"Verification based on digits of the postal code.")]
    PostalCode,
    
    /// <summary>
    /// Electronic commerce transaction secured with the X.509 certificate of a customer.
    /// Encoded/decoded by serializers as "SecureCertificate".
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_N6_9I8VTEeuPIIgba4mCug")]
    [Description(@"Electronic commerce transaction secured with the X.509 certificate of a customer.")]
    SecureCertificate,
    
    /// <summary>
    /// Channel-encrypted transaction.
    /// Encoded/decoded by serializers as "SecuredChannel".
    /// </summary>
    [EnumMember(Value = "SCNL")]
    [IsoId("_N6_9JcVTEeuPIIgba4mCug")]
    [Description(@"Channel-encrypted transaction.")]
    SecuredChannel,
    
    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as "SecureElectronicCommerce".
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_N6_9J8VTEeuPIIgba4mCug")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    SecureElectronicCommerce,
    
    /// <summary>
    /// Shipping address from verification.
    /// Encoded/decoded by serializers as "ShippingAddressFrom".
    /// </summary>
    [EnumMember(Value = "SHAF")]
    [IsoId("_N6_9KcVTEeuPIIgba4mCug")]
    [Description(@"Shipping address from verification.")]
    ShippingAddressFrom,
    
    /// <summary>
    /// Shipping address to verification
    /// Encoded/decoded by serializers as "ShippingAddressTo".
    /// </summary>
    [EnumMember(Value = "SHAT")]
    [IsoId("_N6_9K8VTEeuPIIgba4mCug")]
    [Description(@"Shipping address to verification")]
    ShippingAddressTo,
    
    /// <summary>
    /// Electronic signature capture (handwritten signature).
    /// Encoded/decoded by serializers as "SignatureCapture".
    /// </summary>
    [EnumMember(Value = "CPSG")]
    [IsoId("_N6_9LcVTEeuPIIgba4mCug")]
    [Description(@"Electronic signature capture (handwritten signature).")]
    SignatureCapture,
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as "SocialSecurityNumber".
    /// </summary>
    [EnumMember(Value = "SSNB")]
    [IsoId("_N6_9L8VTEeuPIIgba4mCug")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber,
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// Encoded/decoded by serializers as "TaxIdentificationNumber".
    /// </summary>
    [EnumMember(Value = "TXIN")]
    [IsoId("_N6_9McVTEeuPIIgba4mCug")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    TaxIdentificationNumber,
    
    /// <summary>
    /// A token is used to verify an already performed authentication.
    /// Encoded/decoded by serializers as "AuthenticationToken".
    /// </summary>
    [EnumMember(Value = "TOKA")]
    [IsoId("_N6_9M8VTEeuPIIgba4mCug")]
    [Description(@"A token is used to verify an already performed authentication.")]
    AuthenticationToken,
    
    /// <summary>
    /// Cardholder data provided for verification, for instance social security number, driver license number, passport number.
    /// Encoded/decoded by serializers as "CardholderIdentificationData".
    /// </summary>
    [EnumMember(Value = "CDHI")]
    [IsoId("_N6_9NcVTEeuPIIgba4mCug")]
    [Description(@"Cardholder data provided for verification, for instance social security number, driver license number, passport number.")]
    CardholderIdentificationData,
    
    /// <summary>
    /// Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.
    /// Encoded/decoded by serializers as "TokenAuthentication".
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_N6_9N8VTEeuPIIgba4mCug")]
    [Description(@"Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.")]
    TokenAuthentication,
    
    /// <summary>
    /// QualifiedCertificate
    /// Encoded/decoded by serializers as "QualifiedCertificate".
    /// </summary>
    [EnumMember(Value = "QWAC")]
    [IsoId("_N6_9OcVTEeuPIIgba4mCug")]
    [Description(@"QualifiedCertificate")]
    QualifiedCertificate,
    
    /// <summary>
    /// Customer home phone number.
    /// Encoded/decoded by serializers as "PhoneHome".
    /// </summary>
    [EnumMember(Value = "PHOM")]
    [IsoId("_N6_9O8VTEeuPIIgba4mCug")]
    [Description(@"Customer home phone number.")]
    PhoneHome,
    
    /// <summary>
    /// Customer work phone number
    /// Encoded/decoded by serializers as "PhoneWork".
    /// </summary>
    [EnumMember(Value = "PWOR")]
    [IsoId("_N6_9PcVTEeuPIIgba4mCug")]
    [Description(@"Customer work phone number")]
    PhoneWork,
    
    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as "ThreeDS".
    /// </summary>
    [EnumMember(Value = "THDS")]
    [IsoId("_N6_9P8VTEeuPIIgba4mCug")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    ThreeDS,
    
    /// <summary>
    /// Cardholder billing address verification.
    /// Encoded/decoded by serializers as "BillingAddressVerification".
    /// </summary>
    [EnumMember(Value = "ADDB")]
    [IsoId("_N6_9QcVTEeuPIIgba4mCug")]
    [Description(@"Cardholder billing address verification.")]
    BillingAddressVerification,
    
    /// <summary>
    /// Cardholder shipping address verification.
    /// Encoded/decoded by serializers as "ShippingAddressVerification".
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_N6_9Q8VTEeuPIIgba4mCug")]
    [Description(@"Cardholder shipping address verification.")]
    ShippingAddressVerification,
    
    /// <summary>
    /// Verification of Card Security Code.
    /// Encoded/decoded by serializers as "CSCVerification".
    /// </summary>
    [EnumMember(Value = "CSCV")]
    [IsoId("_N6_9RcVTEeuPIIgba4mCug")]
    [Description(@"Verification of Card Security Code.")]
    CSCVerification,
    
    /// <summary>
    /// Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as "CryptogramVerification".
    /// </summary>
    [EnumMember(Value = "CRYP")]
    [IsoId("_N6_9R8VTEeuPIIgba4mCug")]
    [Description(@"Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).")]
    CryptogramVerification,
    
    /// <summary>
    /// Biometric authentication of the cardholder.
    /// Encoded/decoded by serializers as "Biometry".
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_N6_9ScVTEeuPIIgba4mCug")]
    [Description(@"Biometric authentication of the cardholder.")]
    Biometry,
    
    /// <summary>
    /// Customer mobile device.
    /// Encoded/decoded by serializers as "Mobile".
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_N6_9S8VTEeuPIIgba4mCug")]
    [Description(@"Customer mobile device.")]
    Mobile,
    
    /// <summary>
    /// Off-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as "OfflinePIN".
    /// </summary>
    [EnumMember(Value = "FPIN")]
    [IsoId("_N6_9TcVTEeuPIIgba4mCug")]
    [Description(@"Off-line PIN authentication (Personal Identification Number).")]
    OfflinePIN,
    
    /// <summary>
    /// Nationally assigned identifier.
    /// Encoded/decoded by serializers as "NationalIdentifier".
    /// </summary>
    [EnumMember(Value = "NTID")]
    [IsoId("_Ub_vccVUEeuPIIgba4mCug")]
    [Description(@"Nationally assigned identifier.")]
    NationalIdentifier,
    
    /// <summary>
    /// Serial number of the acceptor's certificate.
    /// Encoded/decoded by serializers as "AcceptorCertificateSerialNumber".
    /// </summary>
    [EnumMember(Value = "ACSN")]
    [IsoId("_VkhdwcVUEeuPIIgba4mCug")]
    [Description(@"Serial number of the acceptor's certificate.")]
    AcceptorCertificateSerialNumber,
    
    /// <summary>
    /// Serial number of the cardholder's certificate.
    /// Encoded/decoded by serializers as "CardholderCertificateSerialNumber".
    /// </summary>
    [EnumMember(Value = "CHSN")]
    [IsoId("_WPDogcVUEeuPIIgba4mCug")]
    [Description(@"Serial number of the cardholder's certificate.")]
    CardholderCertificateSerialNumber,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AuthenticationMethod12CodeMetadataExtensions
{
    private static readonly AuthenticationMethod12CodeDropdownSource _dropdownSource = new AuthenticationMethod12CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAuthenticationMethod12CodeDropdownRow GetMetadata(this AuthenticationMethod12Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


