﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Organisation31.  ISO2002 ID# _1ZjF8YilEeefvMoXmllHqg.
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
/// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
/// </summary>
[IsoId("_1ZjF8YilEeefvMoXmllHqg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Organisation")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Organisation31
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Organisation31 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Organisation31( System.String reqName,PostalAddress1 reqCorporateInvestorAddress )
    {
        Name = reqName;
        CorporateInvestorAddress = reqCorporateInvestorAddress;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which the party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_1pUnUYilEeefvMoXmllHqg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Name { get; init; } 
    #else
    public System.String Name { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for the organisation.
    /// </summary>
    [IsoId("_1pUnU4ilEeefvMoXmllHqg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification124? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification124? Identification { get; init; } 
    #else
    public PartyIdentification124? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Purpose of the organisation, for example, charity.
    /// </summary>
    [IsoId("_1pUnVYilEeefvMoXmllHqg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Purpose")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Purpose { get; init; } 
    #else
    public System.String? Purpose { get; set; } 
    #endif
    
    /// <summary>
    /// Country of taxation of the organisation.
    /// </summary>
    [IsoId("_1pUnV4ilEeefvMoXmllHqg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Taxation Country")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? TaxationCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TaxationCountry { get; init; } 
    #else
    public string? TaxationCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    [IsoId("_1pUnWYilEeefvMoXmllHqg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Registration Country")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? RegistrationCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RegistrationCountry { get; init; } 
    #else
    public string? RegistrationCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_1pUnW4ilEeefvMoXmllHqg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Registration Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? RegistrationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? RegistrationDate { get; init; } 
    #else
    public System.DateOnly? RegistrationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a tax authority to the organisation.
    /// </summary>
    [IsoId("_1pUnXYilEeefvMoXmllHqg")]
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
    public IsoMax35Text? TaxIdentificationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxIdentificationNumber { get; init; } 
    #else
    public System.String? TaxIdentificationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number assigned by a national registration authority to the organisation.
    /// </summary>
    [IsoId("_1pUnX4ilEeefvMoXmllHqg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("National Registration Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? NationalRegistrationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NationalRegistrationNumber { get; init; } 
    #else
    public System.String? NationalRegistrationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Postal address of the organisation.
    /// </summary>
    [IsoId("_1pUnYYilEeefvMoXmllHqg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Corporate Investor Address")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PostalAddress1 CorporateInvestorAddress { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PostalAddress1 CorporateInvestorAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress1 CorporateInvestorAddress { get; init; } 
    #else
    public PostalAddress1 CorporateInvestorAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
