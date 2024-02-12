﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PersonIdentification3.  ISO2002 ID# _QED-o9p-Ed-ak6NoX_4Aeg_-1604713297.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify a person.
/// </summary>
[IsoId("_QED-o9p-Ed-ak6NoX_4Aeg_-1604713297")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Person Identification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PersonIdentification3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PersonIdentification3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PersonIdentification3( System.String reqDriversLicenseNumber,System.String reqCustomerNumber,System.String reqSocialSecurityNumber,System.String reqAlienRegistrationNumber,System.String reqPassportNumber,System.String reqTaxIdentificationNumber,System.String reqIdentityCardNumber,System.String reqEmployerIdentificationNumber,DateAndPlaceOfBirth reqDateAndPlaceOfBirth,GenericIdentification4 reqOtherIdentification )
    {
        DriversLicenseNumber = reqDriversLicenseNumber;
        CustomerNumber = reqCustomerNumber;
        SocialSecurityNumber = reqSocialSecurityNumber;
        AlienRegistrationNumber = reqAlienRegistrationNumber;
        PassportNumber = reqPassportNumber;
        TaxIdentificationNumber = reqTaxIdentificationNumber;
        IdentityCardNumber = reqIdentityCardNumber;
        EmployerIdentificationNumber = reqEmployerIdentificationNumber;
        DateAndPlaceOfBirth = reqDateAndPlaceOfBirth;
        OtherIdentification = reqOtherIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number assigned by a license authority to a driver's license.
    /// </summary>
    [IsoId("_QED-pNp-Ed-ak6NoX_4Aeg_-1604713254")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Drivers License Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text DriversLicenseNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String DriversLicenseNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DriversLicenseNumber { get; init; } 
    #else
    public System.String DriversLicenseNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by an agent to identify its customer.
    /// </summary>
    [IsoId("_QED-pdp-Ed-ak6NoX_4Aeg_140421516")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Customer Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CustomerNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String CustomerNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CustomerNumber { get; init; } 
    #else
    public System.String CustomerNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a social security agency.
    /// </summary>
    [IsoId("_QED-ptp-Ed-ak6NoX_4Aeg_-1604712929")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Social Security Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SocialSecurityNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String SocialSecurityNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SocialSecurityNumber { get; init; } 
    #else
    public System.String SocialSecurityNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// </summary>
    [IsoId("_QED-p9p-Ed-ak6NoX_4Aeg_-1604712869")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Alien Registration Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AlienRegistrationNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String AlienRegistrationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AlienRegistrationNumber { get; init; } 
    #else
    public System.String AlienRegistrationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// </summary>
    [IsoId("_QED-qNp-Ed-ak6NoX_4Aeg_-1604712809")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Passport Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PassportNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String PassportNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PassportNumber { get; init; } 
    #else
    public System.String PassportNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_QED-qdp-Ed-ak6NoX_4Aeg_-1604712757")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Identification Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TaxIdentificationNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String TaxIdentificationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TaxIdentificationNumber { get; init; } 
    #else
    public System.String TaxIdentificationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// </summary>
    [IsoId("_QED-qtp-Ed-ak6NoX_4Aeg_-1604712462")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identity Card Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text IdentityCardNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String IdentityCardNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IdentityCardNumber { get; init; } 
    #else
    public System.String IdentityCardNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// </summary>
    [IsoId("_QED-q9p-Ed-ak6NoX_4Aeg_-1604712402")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Employer Identification Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text EmployerIdentificationNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String EmployerIdentificationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EmployerIdentificationNumber { get; init; } 
    #else
    public System.String EmployerIdentificationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date and place of birth of a person.
    /// </summary>
    [IsoId("_QENIkNp-Ed-ak6NoX_4Aeg_-1597135816")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Date And Place Of Birth")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndPlaceOfBirth DateAndPlaceOfBirth { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DateAndPlaceOfBirth DateAndPlaceOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndPlaceOfBirth DateAndPlaceOfBirth { get; init; } 
    #else
    public DateAndPlaceOfBirth DateAndPlaceOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier issued to a person for which no specific identifier has been defined.
    /// </summary>
    [IsoId("_QENIkdp-Ed-ak6NoX_4Aeg_-1604711972")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification4 OtherIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public GenericIdentification4 OtherIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification4 OtherIdentification { get; init; } 
    #else
    public GenericIdentification4 OtherIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    [IsoId("_QENIktp-Ed-ak6NoX_4Aeg_-495106709")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issuer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Issuer { get; init; } 
    #else
    public System.String? Issuer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
