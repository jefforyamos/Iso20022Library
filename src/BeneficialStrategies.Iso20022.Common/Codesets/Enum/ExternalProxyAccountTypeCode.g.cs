﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalProxyAccountTypeCode.  ISO2002 ID# _ioPgo3h3EeidzqjNEfehPg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external proxy account type code, as published in the proxy account type external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ioPgo3h3EeidzqjNEfehPg")]
[Description(@"Specifies the external proxy account type code, as published in the proxy account type external code set. External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalProxyAccountType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum ExternalProxyAccountTypeCode
{
    /// <summary>
    /// A telephone number in the format specified by the 'The international public telecommunication numbering plan ITU-T E.164. 
    /// Encoded/decoded by serializers as "TELE".
    /// </summary>
    [EnumMember(Value = "TELE")]
    [IsoId("_um0ydvRYEeuLhpyIdtJzwg")]
    [Description(@"A telephone number in the format specified by the 'The international public telecommunication numbering plan ITU-T E.164. ")]
    TelephoneNumber,
    
    /// <summary>
    /// Internationalised address of an electronic mail box for internet messages.
    /// Encoded/decoded by serializers as "EMAL".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_um0yefRYEeuLhpyIdtJzwg")]
    [Description(@"Internationalised address of an electronic mail box for internet messages.")]
    EmailAddress,
    
    /// <summary>
    /// Internationalised internet domain name.
    /// Encoded/decoded by serializers as "DNAM".
    /// </summary>
    [EnumMember(Value = "DNAM")]
    [IsoId("_um-jcPRYEeuLhpyIdtJzwg")]
    [Description(@"Internationalised internet domain name.")]
    DomainName,
    
    /// <summary>
    /// Account proxy issued by a payment scheme (applied for corporate or individual account proxy).|Use cases: Any proxies issued by clearing systems, for example VPA (India), FPS Identifier (Hong Kong), Jompay (Malaysia) CCIN (Canada).
    /// Encoded/decoded by serializers as "SHID".
    /// </summary>
    [EnumMember(Value = "SHID")]
    [IsoId("_VZYoMJuREeya_t2LwNmi4g")]
    [Description(@"Account proxy issued by a payment scheme (applied for corporate or individual account proxy).|Use cases: Any proxies issued by clearing systems, for example VPA (India), FPS Identifier (Hong Kong), Jompay (Malaysia) CCIN (Canada).")]
    SchemeIdentificationNumber,
    
    /// <summary>
    /// Mobile phone number in the format specified by the “The international public telecommunication numbering plan ITU- T E 164" (applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as "MBNO".
    /// </summary>
    [EnumMember(Value = "MBNO")]
    [IsoId("_r5btsJuREeya_t2LwNmi4g")]
    [Description(@"Mobile phone number in the format specified by the “The international public telecommunication numbering plan ITU- T E 164"" (applied for corporate or individual account proxy).")]
    MobilePhoneNumber,
    
    /// <summary>
    /// Billers of specific utilities could register for a Biller Identification as supported in the clearing scheme, and use this identification for collections (applied for corporate account proxy).
    /// Encoded/decoded by serializers as "BIID".
    /// </summary>
    [EnumMember(Value = "BIID")]
    [IsoId("_5BkBkJuREeya_t2LwNmi4g")]
    [Description(@"Billers of specific utilities could register for a Biller Identification as supported in the clearing scheme, and use this identification for collections (applied for corporate account proxy).")]
    BillerSubscriberIdentification,
    
    /// <summary>
    /// Market-adopted prepaid instruments like e-Wallets, payments to / from e-wallets from / to bank accounts (applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as "EWAL".
    /// </summary>
    [EnumMember(Value = "EWAL")]
    [IsoId("_Es2kAJuSEeya_t2LwNmi4g")]
    [Description(@"Market-adopted prepaid instruments like e-Wallets, payments to / from e-wallets from / to bank accounts (applied for corporate or individual account proxy).")]
    EWalletIdentification,
    
    /// <summary>
    /// Account proxy for receiving insurance claims, pay insurance premium, road tax payments, traffic tickets etc.(applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as "VIPN".
    /// </summary>
    [EnumMember(Value = "VIPN")]
    [IsoId("_USyXEJuSEeya_t2LwNmi4g")]
    [Description(@"Account proxy for receiving insurance claims, pay insurance premium, road tax payments, traffic tickets etc.(applied for corporate or individual account proxy).")]
    VehicleIdentificationPlateNumber,
    
    /// <summary>
    /// Subscriber Identification for utilities and services. As opposed to a biller Identification, this identification is used for the subscriber of the service (applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as "UBIL".
    /// </summary>
    [EnumMember(Value = "UBIL")]
    [IsoId("_pEay8JuSEeya_t2LwNmi4g")]
    [Description(@"Subscriber Identification for utilities and services. As opposed to a biller Identification, this identification is used for the subscriber of the service (applied for corporate or individual account proxy).")]
    UtilitiesSubscriptionIdentification,
    
    /// <summary>
    /// Unique government-issued Identification  used as account proxy to identify the individual  (for example for public benefits) and typically linked to the individual's bank account (applied for individual account proxy).
    /// Encoded/decoded by serializers as "SOSE".
    /// </summary>
    [EnumMember(Value = "SOSE")]
    [IsoId("_yTjcAJuSEeya_t2LwNmi4g")]
    [Description(@"Unique government-issued Identification  used as account proxy to identify the individual  (for example for public benefits) and typically linked to the individual's bank account (applied for individual account proxy).")]
    SocialSecurityNumber,
    
    /// <summary>
    /// Unique government-issued Identification  used as account proxy to  identify the individual  or corporate for example for public benefits, government subsidies) and typically linked to the individual's / corporate bank account.|(applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as "NIDN".
    /// </summary>
    [EnumMember(Value = "NIDN")]
    [IsoId("__8TwsJuSEeya_t2LwNmi4g")]
    [Description(@"Unique government-issued Identification  used as account proxy to  identify the individual  or corporate for example for public benefits, government subsidies) and typically linked to the individual's / corporate bank account.|(applied for corporate or individual account proxy).")]
    NationalIdentificationNumber,
    
    /// <summary>
    /// Unique government-issued Identification  used as account proxy to  identify the individual  (for example for government charges, road taxes, vaccination charges) and typically linked to the individual's bank account|(applied for  individual account proxy).
    /// Encoded/decoded by serializers as "CCPT".
    /// </summary>
    [EnumMember(Value = "CCPT")]
    [IsoId("_H8deIJuTEeya_t2LwNmi4g")]
    [Description(@"Unique government-issued Identification  used as account proxy to  identify the individual  (for example for government charges, road taxes, vaccination charges) and typically linked to the individual's bank account|(applied for  individual account proxy).")]
    PassportNumber,
    
    /// <summary>
    /// Unique government-issued Identification used as account proxy to  identify the individual  (for example for government charges, road taxes and tolls,vaccination charges) and typically linked to the individual's bank account (applied for  individual account proxy).
    /// Encoded/decoded by serializers as "DRLC".
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_RHH24JuTEeya_t2LwNmi4g")]
    [Description(@"Unique government-issued Identification used as account proxy to  identify the individual  (for example for government charges, road taxes and tolls,vaccination charges) and typically linked to the individual's bank account (applied for  individual account proxy).")]
    DriverLicenseNumber,
    
    /// <summary>
    /// Government-issued Identification (different from a passport Identification or a national Identification). Used as account proxy to  identify the individual (for example for public benefits) and typically linked to the individual's bank account (applied for  individual account proxy).
    /// Encoded/decoded by serializers as "EIDN".
    /// </summary>
    [EnumMember(Value = "EIDN")]
    [IsoId("_fBeR4JuTEeya_t2LwNmi4g")]
    [Description(@"Government-issued Identification (different from a passport Identification or a national Identification). Used as account proxy to  identify the individual (for example for public benefits) and typically linked to the individual's bank account (applied for  individual account proxy).")]
    ElectronicIdentification,
    
    /// <summary>
    /// Unique government-issued tax Identification used as account proxy to identify the corporate (for example for government tax) and typically linked to the corporate bank account (applied for corporate account proxy).
    /// Encoded/decoded by serializers as "COTX".
    /// </summary>
    [EnumMember(Value = "COTX")]
    [IsoId("_oNeHYJuTEeya_t2LwNmi4g")]
    [Description(@"Unique government-issued tax Identification used as account proxy to identify the corporate (for example for government tax) and typically linked to the corporate bank account (applied for corporate account proxy).")]
    CorporateTaxIdentification,
    
    /// <summary>
    /// Unique government-issued  tax Identification  used as account proxy to  identify the individual  for example for government tax) and typically linked to the individual's bank account (applied for  individual account proxy).
    /// Encoded/decoded by serializers as "PVTX".
    /// </summary>
    [EnumMember(Value = "PVTX")]
    [IsoId("_Hcw08JuUEeya_t2LwNmi4g")]
    [Description(@"Unique government-issued  tax Identification  used as account proxy to  identify the individual  for example for government tax) and typically linked to the individual's bank account (applied for  individual account proxy).")]
    IndividualTaxIdentification,
    
    /// <summary>
    /// Identification issued by a national  institution or regulator (different from a national scheme like a clearing provider), used as account proxy (applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as "COID".
    /// </summary>
    [EnumMember(Value = "COID")]
    [IsoId("_QRhPIJuUEeya_t2LwNmi4g")]
    [Description(@"Identification issued by a national  institution or regulator (different from a national scheme like a clearing provider), used as account proxy (applied for corporate or individual account proxy).")]
    CountryAuthorityIdentification,
    
    /// <summary>
    /// Legal Entity Identifier used as account proxy (applied for corporate account proxy).|Use cases: Can be used by corporates as a "government-issued" Identification for registration with payment schemes as a proxy. The proxy may be further used for payments and collections using the underlying instant payment rails for a variety of corporate use cases.
    /// Encoded/decoded by serializers as "LEIC".
    /// </summary>
    [EnumMember(Value = "LEIC")]
    [IsoId("_YhUiIJuUEeya_t2LwNmi4g")]
    [Description(@"Legal Entity Identifier used as account proxy (applied for corporate account proxy).|Use cases: Can be used by corporates as a ""government-issued"" Identification for registration with payment schemes as a proxy. The proxy may be further used for payments and collections using the underlying instant payment rails for a variety of corporate use cases.")]
    LegalEntityIdentifierCode,
    
    /// <summary>
    /// Corporate Identification issued by a national  institution or regulator, used as account proxy. |(applied for corporate account proxy).
    /// Encoded/decoded by serializers as "CINC".
    /// </summary>
    [EnumMember(Value = "CINC")]
    [IsoId("_h5GJ0JuUEeya_t2LwNmi4g")]
    [Description(@"Corporate Identification issued by a national  institution or regulator, used as account proxy. |(applied for corporate account proxy).")]
    CertificateOfIncorporationNumber,
    
    /// <summary>
    /// Electronic Identification used, for example, to mask an account number as a means of data secrecy.|(applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as "TOKN".
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_tYwrEJuUEeya_t2LwNmi4g")]
    [Description(@"Electronic Identification used, for example, to mask an account number as a means of data secrecy.|(applied for corporate or individual account proxy).")]
    TokenIdentification,
    
    /// <summary>
    /// Any other customer identification number issued by a corporate, bank or other organization, used as account proxy.|(applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_4X88gJuUEeya_t2LwNmi4g")]
    [Description(@"Any other customer identification number issued by a corporate, bank or other organization, used as account proxy.|(applied for corporate or individual account proxy).")]
    CustomerIdentificationNumber,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalProxyAccountTypeCodeMetadataExtensions
{
    private static readonly ExternalProxyAccountTypeCodeDropdownSource _dropdownSource = new ExternalProxyAccountTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalProxyAccountTypeCodeDropdownRow GetMetadata(this ExternalProxyAccountTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


