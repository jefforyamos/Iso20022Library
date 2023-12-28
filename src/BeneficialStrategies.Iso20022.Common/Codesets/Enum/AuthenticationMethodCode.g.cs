﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AuthenticationMethodCode.  ISO2002 ID# _TV8F4AEcEeCQm6a_G2yO_w_-487459684.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Method used to authenticate a cardholder.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TV8F4AEcEeCQm6a_G2yO_w_-487459684")]
[Description(@"Method used to authenticate a cardholder.")]
public enum AuthenticationMethodCode
{
    /// <summary>
    /// Authentication method is performed unknown.
    /// Encoded/decoded by serializers as "UKNW".
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_TV8F4QEcEeCQm6a_G2yO_w_567294757")]
    [Description(@"Authentication method is performed unknown.")]
    UnknownMethod,
    
    /// <summary>
    /// Authentication bypassed by the merchant.
    /// Encoded/decoded by serializers as "BYPS".
    /// </summary>
    [EnumMember(Value = "BYPS")]
    [IsoId("_TV8F4gEcEeCQm6a_G2yO_w_-822486963")]
    [Description(@"Authentication bypassed by the merchant.")]
    Bypass,
    
    /// <summary>
    /// On-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as "NPIN".
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_TV8F4wEcEeCQm6a_G2yO_w_1462523475")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    OnLinePIN,
    
    /// <summary>
    /// Off-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as "FPIN".
    /// </summary>
    [EnumMember(Value = "FPIN")]
    [IsoId("_TV8F5AEcEeCQm6a_G2yO_w_-1792409526")]
    [Description(@"Off-line PIN authentication (Personal Identification Number).")]
    OfflinePIN,
    
    /// <summary>
    /// Electronic signature capture (handwritten signature).
    /// Encoded/decoded by serializers as "CPSG".
    /// </summary>
    [EnumMember(Value = "CPSG")]
    [IsoId("_TV8F5QEcEeCQm6a_G2yO_w_2072925403")]
    [Description(@"Electronic signature capture (handwritten signature).")]
    SignatureCapture,
    
    /// <summary>
    /// Handwritten paper signature.
    /// Encoded/decoded by serializers as "PPSG".
    /// </summary>
    [EnumMember(Value = "PPSG")]
    [IsoId("_TV8F5gEcEeCQm6a_G2yO_w_-2090444660")]
    [Description(@"Handwritten paper signature.")]
    PaperSignature,
    
    /// <summary>
    /// Manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as "MANU".
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_TV8F5wEcEeCQm6a_G2yO_w_-743732481")]
    [Description(@"Manual verification, for example passport or drivers license.")]
    ManualVerification,
    
    /// <summary>
    /// Merchant-related authentication.
    /// Encoded/decoded by serializers as "MERC".
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_TV8F6AEcEeCQm6a_G2yO_w_-2133514201")]
    [Description(@"Merchant-related authentication.")]
    MerchantAuthentication,
    
    /// <summary>
    /// Electronic commerce transaction secured with the X.509 certificate of a customer.
    /// Encoded/decoded by serializers as "SCRT".
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_TV8F6QEcEeCQm6a_G2yO_w_151496237")]
    [Description(@"Electronic commerce transaction secured with the X.509 certificate of a customer.")]
    SecureCertificate,
    
    /// <summary>
    /// Secure electronic transaction without cardholder certificate.
    /// Encoded/decoded by serializers as "SNCT".
    /// </summary>
    [EnumMember(Value = "SNCT")]
    [IsoId("_TV8F6gEcEeCQm6a_G2yO_w_1554634082")]
    [Description(@"Secure electronic transaction without cardholder certificate.")]
    SecureNoCertificate,
    
    /// <summary>
    /// Channel-encrypted transaction.
    /// Encoded/decoded by serializers as "SCNL".
    /// </summary>
    [EnumMember(Value = "SCNL")]
    [IsoId("_TV8F6wEcEeCQm6a_G2yO_w_761898165")]
    [Description(@"Channel-encrypted transaction.")]
    SecuredChannel,
    
    /// <summary>
    /// Authentication by a password.
    /// Encoded/decoded by serializers as "PSWD".
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_sQJJ8b4pEeKkGaJ0UrThyA_1833629628")]
    [Description(@"Authentication by a password.")]
    Password,
    
    /// <summary>
    /// Cardholder billing address verification.
    /// Encoded/decoded by serializers as "ADDB".
    /// </summary>
    [EnumMember(Value = "ADDB")]
    [IsoId("_e8XqMGjNEeSHBr6v3XO0Mg")]
    [Description(@"Cardholder billing address verification.")]
    BillingAddressVerification,
    
    /// <summary>
    /// Biometric authentication of the cardholder.
    /// Encoded/decoded by serializers as "BIOM".
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_h4zmIGjNEeSHBr6v3XO0Mg")]
    [Description(@"Biometric authentication of the cardholder.")]
    Biometry,
    
    /// <summary>
    /// Cardholder data provided for verification, for instance social security number, driver license number, passport number.
    /// Encoded/decoded by serializers as "CDHI".
    /// </summary>
    [EnumMember(Value = "CDHI")]
    [IsoId("_lJxnoGjNEeSHBr6v3XO0Mg")]
    [Description(@"Cardholder data provided for verification, for instance social security number, driver license number, passport number.")]
    CardholderIdentificationData,
    
    /// <summary>
    /// Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as "CRYP".
    /// </summary>
    [EnumMember(Value = "CRYP")]
    [IsoId("_vHcKoGjNEeSHBr6v3XO0Mg")]
    [Description(@"Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).")]
    CryptogramVerification,
    
    /// <summary>
    /// Verification of Card Security Code.
    /// Encoded/decoded by serializers as "CSCV".
    /// </summary>
    [EnumMember(Value = "CSCV")]
    [IsoId("_01RQIGjNEeSHBr6v3XO0Mg")]
    [Description(@"Verification of Card Security Code.")]
    CSCVerification,
    
    /// <summary>
    /// Authentication based on statistical cardholder behaviour.
    /// Encoded/decoded by serializers as "PSVE".
    /// </summary>
    [EnumMember(Value = "PSVE")]
    [IsoId("_31GeUGjNEeSHBr6v3XO0Mg")]
    [Description(@"Authentication based on statistical cardholder behaviour.")]
    PassiveAuthentication,
    
    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as "CSEC".
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_8Qu8IGjNEeSHBr6v3XO0Mg")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    SecureElectronicCommerce,
    
    /// <summary>
    /// Cardholder shipping address verification.
    /// Encoded/decoded by serializers as "ADDS".
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_ADNIMGjOEeSHBr6v3XO0Mg")]
    [Description(@"Cardholder shipping address verification.")]
    ShippingAddressVerification,
    
    /// <summary>
    /// Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.
    /// Encoded/decoded by serializers as "TOKN".
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_ECBHIGjOEeSHBr6v3XO0Mg")]
    [Description(@"Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.")]
    TokenAuthentication,
    
    /// <summary>
    /// Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.
    /// Encoded/decoded by serializers as "TOKP".
    /// </summary>
    [EnumMember(Value = "TOKP")]
    [IsoId("_-TkAYIIEEeS7UOLM47txvA")]
    [Description(@"Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.")]
    PaymentToken,
    
    /// <summary>
    /// A token is used to verify an already performed authentication.
    /// Encoded/decoded by serializers as "TOKA".
    /// </summary>
    [EnumMember(Value = "TOKA")]
    [IsoId("_or5w0IoaEeSirOZJBRz_nA")]
    [Description(@"A token is used to verify an already performed authentication.")]
    AuthenticationToken,
    
    /// <summary>
    /// Customer mobile device.
    /// Encoded/decoded by serializers as "MOBL".
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_sHfG4IoaEeSirOZJBRz_nA")]
    [Description(@"Customer mobile device.")]
    Mobile,
    
    /// <summary>
    /// Other customer authentication.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_xzNTkIoaEeSirOZJBRz_nA")]
    [Description(@"Other customer authentication.")]
    Other,
    
    /// <summary>
    /// Digits of the address.
    /// Encoded/decoded by serializers as "ADVF".
    /// </summary>
    [EnumMember(Value = "ADVF")]
    [IsoId("_NYJzdHyPEemHsOqJOzMVfg")]
    [Description(@"Digits of the address.")]
    AddressDigits,
    
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as "ARNB".
    /// </summary>
    [EnumMember(Value = "ARNB")]
    [IsoId("_NYJzdXyPEemHsOqJOzMVfg")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber,
    
    /// <summary>
    /// Verification of a cryptogram generated by a chip card, for instance an ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as "ARQC".
    /// </summary>
    [EnumMember(Value = "ARQC")]
    [IsoId("_NYJzdnyPEemHsOqJOzMVfg")]
    [Description(@"Verification of a cryptogram generated by a chip card, for instance an ARQC (Authorisation Request Cryptogram).")]
    ARQCVerification,
    
    /// <summary>
    /// Date of birth of a person.
    /// Encoded/decoded by serializers as "BTHD".
    /// </summary>
    [EnumMember(Value = "BTHD")]
    [IsoId("_NYJzd3yPEemHsOqJOzMVfg")]
    [Description(@"Date of birth of a person.")]
    BirthDate,
    
    /// <summary>
    /// Name of cardholder
    /// Encoded/decoded by serializers as "CHDN".
    /// </summary>
    [EnumMember(Value = "CHDN")]
    [IsoId("_NYJzeHyPEemHsOqJOzMVfg")]
    [Description(@"Name of cardholder")]
    CardholderName,
    
    /// <summary>
    /// City of birth to authenticate a person.
    /// Encoded/decoded by serializers as "COFB".
    /// </summary>
    [EnumMember(Value = "COFB")]
    [IsoId("_NYJzeXyPEemHsOqJOzMVfg")]
    [Description(@"City of birth to authenticate a person.")]
    CityOfBirth,
    
    /// <summary>
    /// Customer number used as a mechanism of authentication.
    /// Encoded/decoded by serializers as "CUID".
    /// </summary>
    [EnumMember(Value = "CUID")]
    [IsoId("_NYJzenyPEemHsOqJOzMVfg")]
    [Description(@"Customer number used as a mechanism of authentication.")]
    CustomerIdentification,
    
    /// <summary>
    /// Identification of a driver in a fleet of vehicles.
    /// Encoded/decoded by serializers as "DRVI".
    /// </summary>
    [EnumMember(Value = "DRVI")]
    [IsoId("_NYJze3yPEemHsOqJOzMVfg")]
    [Description(@"Identification of a driver in a fleet of vehicles.")]
    DriverIdentification,
    
    /// <summary>
    /// Number assigned by a driving license authority to a person driving a car.
    /// Encoded/decoded by serializers as "DRLN".
    /// </summary>
    [EnumMember(Value = "DRLN")]
    [IsoId("_NYJzfHyPEemHsOqJOzMVfg")]
    [Description(@"Number assigned by a driving license authority to a person driving a car.")]
    DriverLicenseNumber,
    
    /// <summary>
    /// Electronic mail address
    /// Encoded/decoded by serializers as "EMAL".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_NYJzfXyPEemHsOqJOzMVfg")]
    [Description(@"Electronic mail address")]
    Email,
    
    /// <summary>
    /// Number assigned to an employee by an employer.
    /// Encoded/decoded by serializers as "EMIN".
    /// </summary>
    [EnumMember(Value = "EMIN")]
    [IsoId("_NYJzfnyPEemHsOqJOzMVfg")]
    [Description(@"Number assigned to an employee by an employer.")]
    EmployeeIdentificationNumber,
    
    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// Encoded/decoded by serializers as "EMRN".
    /// </summary>
    [EnumMember(Value = "EMRN")]
    [IsoId("_NYJzf3yPEemHsOqJOzMVfg")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    EmployerIdentificationNumber,
    
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as "IDCN".
    /// </summary>
    [EnumMember(Value = "IDCN")]
    [IsoId("_NYJzgHyPEemHsOqJOzMVfg")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber,
    
    /// <summary>
    /// Verification of a one-time password provided by the issuer.
    /// Encoded/decoded by serializers as "OTPW".
    /// </summary>
    [EnumMember(Value = "OTPW")]
    [IsoId("_NYJzgXyPEemHsOqJOzMVfg")]
    [Description(@"Verification of a one-time password provided by the issuer.")]
    OneTimePassword,
    
    /// <summary>
    /// Other cardholder data provided for identification.
    /// Encoded/decoded by serializers as "OCHI".
    /// </summary>
    [EnumMember(Value = "OCHI")]
    [IsoId("_NYJzgnyPEemHsOqJOzMVfg")]
    [Description(@"Other cardholder data provided for identification.")]
    OtherCardholderIdentification,
    
    /// <summary>
    /// Verification of a cryptogram generated by a non-card form factor.
    /// Encoded/decoded by serializers as "OTHC".
    /// </summary>
    [EnumMember(Value = "OTHC")]
    [IsoId("_NYJzg3yPEemHsOqJOzMVfg")]
    [Description(@"Verification of a cryptogram generated by a non-card form factor.")]
    OtherCryptogram,
    
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as "PASN".
    /// </summary>
    [EnumMember(Value = "PASN")]
    [IsoId("_NYJzhHyPEemHsOqJOzMVfg")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber,
    
    /// <summary>
    /// Verification based on digits of the postal code.
    /// Encoded/decoded by serializers as "PCDV".
    /// </summary>
    [EnumMember(Value = "PCDV")]
    [IsoId("_NYJzhXyPEemHsOqJOzMVfg")]
    [Description(@"Verification based on digits of the postal code.")]
    PostalCode,
    
    /// <summary>
    /// Shipping address from verification.
    /// Encoded/decoded by serializers as "SHAF".
    /// </summary>
    [EnumMember(Value = "SHAF")]
    [IsoId("_NYJzhnyPEemHsOqJOzMVfg")]
    [Description(@"Shipping address from verification.")]
    ShippingAddressFrom,
    
    /// <summary>
    /// Shipping address to verification
    /// Encoded/decoded by serializers as "SHAT".
    /// </summary>
    [EnumMember(Value = "SHAT")]
    [IsoId("_NYJzh3yPEemHsOqJOzMVfg")]
    [Description(@"Shipping address to verification")]
    ShippingAddressTo,
    
    /// <summary>
    /// Verification whether the address corresponds to the cardholder's one.
    /// Encoded/decoded by serializers as "CHSA".
    /// </summary>
    [EnumMember(Value = "CHSA")]
    [IsoId("_Wxx1N3yPEemHsOqJOzMVfg")]
    [Description(@"Verification whether the address corresponds to the cardholder's one.")]
    CardholderAddress,
    
    /// <summary>
    /// Non visible Card Security Code.
    /// Encoded/decoded by serializers as "NVSC".
    /// </summary>
    [EnumMember(Value = "NVSC")]
    [IsoId("_Wxx1OHyPEemHsOqJOzMVfg")]
    [Description(@"Non visible Card Security Code.")]
    NonVisibleCSC,
    
    /// <summary>
    /// Other type of verification defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_Wxx1OXyPEemHsOqJOzMVfg")]
    [Description(@"Other type of verification defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of verification defined at private level
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_Wxx1OnyPEemHsOqJOzMVfg")]
    [Description(@"Other type of verification defined at private level")]
    OtherPrivate,
    
    /// <summary>
    /// Place of birth of a person.
    /// Encoded/decoded by serializers as "PLOB".
    /// </summary>
    [EnumMember(Value = "PLOB")]
    [IsoId("_Wxx1O3yPEemHsOqJOzMVfg")]
    [Description(@"Place of birth of a person.")]
    PlaceOfBirth,
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as "SSNB".
    /// </summary>
    [EnumMember(Value = "SSNB")]
    [IsoId("_Wxx1PHyPEemHsOqJOzMVfg")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber,
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// Encoded/decoded by serializers as "TXIN".
    /// </summary>
    [EnumMember(Value = "TXIN")]
    [IsoId("_Wxx1PXyPEemHsOqJOzMVfg")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    TaxIdentificationNumber,
    
    /// <summary>
    /// Account-based digital signature authentication.
    /// Encoded/decoded by serializers as "APKI".
    /// </summary>
    [EnumMember(Value = "APKI")]
    [IsoId("_wcguD3yPEemHsOqJOzMVfg")]
    [Description(@"Account-based digital signature authentication.")]
    AccountDigitalSignature,
    
    /// <summary>
    /// Response Card Cryptogram (ARPC)  verification.
    /// Encoded/decoded by serializers as "ARPC".
    /// </summary>
    [EnumMember(Value = "ARPC")]
    [IsoId("_wcguEHyPEemHsOqJOzMVfg")]
    [Description(@"Response Card Cryptogram (ARPC)  verification.")]
    ARPCVerification,
    
    /// <summary>
    /// Application Transaction Counter
    /// Encoded/decoded by serializers as "ATCC".
    /// </summary>
    [EnumMember(Value = "ATCC")]
    [IsoId("_wcguEXyPEemHsOqJOzMVfg")]
    [Description(@"Application Transaction Counter")]
    ATC,
    
    /// <summary>
    /// Biographics authentication in an offline mode.
    /// Encoded/decoded by serializers as "FBIG".
    /// </summary>
    [EnumMember(Value = "FBIG")]
    [IsoId("_wcguEnyPEemHsOqJOzMVfg")]
    [Description(@"Biographics authentication in an offline mode.")]
    OffLineBiographics,
    
    /// <summary>
    /// Biometrics authentication in an offline mode
    /// Encoded/decoded by serializers as "FBIO".
    /// </summary>
    [EnumMember(Value = "FBIO")]
    [IsoId("_wcguE3yPEemHsOqJOzMVfg")]
    [Description(@"Biometrics authentication in an offline mode")]
    OffLineBiometrics,
    
    /// <summary>
    /// Authentication of data in an offline mode
    /// Encoded/decoded by serializers as "OLDA".
    /// </summary>
    [EnumMember(Value = "OLDA")]
    [IsoId("_wcguFHyPEemHsOqJOzMVfg")]
    [Description(@"Authentication of data in an offline mode")]
    OffLineDataAuthentication,
    
    /// <summary>
    /// Analysis of signature transmitted offline
    /// Encoded/decoded by serializers as "OLDS".
    /// </summary>
    [EnumMember(Value = "OLDS")]
    [IsoId("_wcguFXyPEemHsOqJOzMVfg")]
    [Description(@"Analysis of signature transmitted offline")]
    OffLineDigitisedSignatureAnalysis,
    
    /// <summary>
    /// PIN generated offline and transmitted encrypted
    /// Encoded/decoded by serializers as "OFPE".
    /// </summary>
    [EnumMember(Value = "OFPE")]
    [IsoId("_wcguFnyPEemHsOqJOzMVfg")]
    [Description(@"PIN generated offline and transmitted encrypted")]
    OffLinePINEncrypted,
    
    /// <summary>
    /// PIN generated offline and transmitted in clear
    /// Encoded/decoded by serializers as "FCPN".
    /// </summary>
    [EnumMember(Value = "FCPN")]
    [IsoId("_wcguF3yPEemHsOqJOzMVfg")]
    [Description(@"PIN generated offline and transmitted in clear")]
    OffLinePINInClear,
    
    /// <summary>
    /// Biographics authentication in an online mode.
    /// Encoded/decoded by serializers as "NBIG".
    /// </summary>
    [EnumMember(Value = "NBIG")]
    [IsoId("_wcguGHyPEemHsOqJOzMVfg")]
    [Description(@"Biographics authentication in an online mode.")]
    OnLineBiographics,
    
    /// <summary>
    /// Customer home phone number.
    /// Encoded/decoded by serializers as "PHOM".
    /// </summary>
    [EnumMember(Value = "PHOM")]
    [IsoId("_wcguGXyPEemHsOqJOzMVfg")]
    [Description(@"Customer home phone number.")]
    PhoneHome,
    
    /// <summary>
    /// Customer work phone number
    /// Encoded/decoded by serializers as "PWOR".
    /// </summary>
    [EnumMember(Value = "PWOR")]
    [IsoId("_wcguGnyPEemHsOqJOzMVfg")]
    [Description(@"Customer work phone number")]
    PhoneWork,
    
    /// <summary>
    /// PKI (Public Key Infrastructure) based digital signature
    /// Encoded/decoded by serializers as "PKIS".
    /// </summary>
    [EnumMember(Value = "PKIS")]
    [IsoId("_wcguG3yPEemHsOqJOzMVfg")]
    [Description(@"PKI (Public Key Infrastructure) based digital signature")]
    PKISignature,
    
    /// <summary>
    /// QualifiedCertificate
    /// Encoded/decoded by serializers as "QWAC".
    /// </summary>
    [EnumMember(Value = "QWAC")]
    [IsoId("_wcguHHyPEemHsOqJOzMVfg")]
    [Description(@"QualifiedCertificate")]
    QualifiedCertificate,
    
    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as "THDS".
    /// </summary>
    [EnumMember(Value = "THDS")]
    [IsoId("_wcguHXyPEemHsOqJOzMVfg")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    ThreeDS,
    
    /// <summary>
    /// Serial number of the cardholder's certificate.
    /// Encoded/decoded by serializers as "CHSN".
    /// </summary>
    [EnumMember(Value = "CHSN")]
    [IsoId("_Zq8WAMVTEeuPIIgba4mCug")]
    [Description(@"Serial number of the cardholder's certificate.")]
    CardholderCertificateSerialNumber,
    
    /// <summary>
    /// Serial number of the acceptor's certificate.
    /// Encoded/decoded by serializers as "ACSN".
    /// </summary>
    [EnumMember(Value = "ACSN")]
    [IsoId("_4mZhkMVTEeuPIIgba4mCug")]
    [Description(@"Serial number of the acceptor's certificate.")]
    AcceptorCertificateSerialNumber,
    
    /// <summary>
    /// Nationally assigned identifier.
    /// Encoded/decoded by serializers as "NTID".
    /// </summary>
    [EnumMember(Value = "NTID")]
    [IsoId("_JkrAkMVUEeuPIIgba4mCug")]
    [Description(@"Nationally assigned identifier.")]
    NationalIdentifier,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AuthenticationMethodCodeMetadataExtensions
{
    private static readonly AuthenticationMethodCodeDropdownSource _dropdownSource = new AuthenticationMethodCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAuthenticationMethodCodeDropdownRow GetMetadata(this AuthenticationMethodCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


