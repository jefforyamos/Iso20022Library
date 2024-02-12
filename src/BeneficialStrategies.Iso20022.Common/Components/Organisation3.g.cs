﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Organisation3.  ISO2002 ID# _QNmVKdp-Ed-ak6NoX_4Aeg_-1024878477.
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
/// Organised structure that is set up for a particular purpose, eg, a business, government body, department, charity, or financial institution.
/// </summary>
[IsoId("_QNmVKdp-Ed-ak6NoX_4Aeg_-1024878477")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Organisation")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Organisation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Organisation3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Organisation3( System.String reqName )
    {
        Name = reqName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QNvfENp-Ed-ak6NoX_4Aeg_-1024878451")]
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
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun & Bradstreet Identification.
    /// </summary>
    [IsoId("_QNvfEdp-Ed-ak6NoX_4Aeg_-1024878400")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification4Choice_? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification4Choice_? Identification { get; init; } 
    #else
    public PartyIdentification4Choice_? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Purpose of the organisation, eg, charity.
    /// </summary>
    [IsoId("_QNvfEtp-Ed-ak6NoX_4Aeg_-1024878123")]
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
    /// Country of taxation of an individual person or an organisation.
    /// </summary>
    [IsoId("_QNvfE9p-Ed-ak6NoX_4Aeg_-1024878070")]
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
    [IsoId("_QNvfFNp-Ed-ak6NoX_4Aeg_-1024878010")]
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
    [IsoId("_QNvfFdp-Ed-ak6NoX_4Aeg_-1024877702")]
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
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    [IsoId("_QNvfFtp-Ed-ak6NoX_4Aeg_-1805973863")]
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
    /// Number assigned by a national registration authority to an entity.
    /// </summary>
    [IsoId("_QNvfF9p-Ed-ak6NoX_4Aeg_-1805973435")]
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
    /// Address information to be either inserted, updated or deleted.
    /// </summary>
    [IsoId("_QNvfGNp-Ed-ak6NoX_4Aeg_-1024877512")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Modified Postal Address")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [MinLength(0)]
    [MaxLength(5)]
    #endif
    public ValueList<ModificationScope1> ModifiedPostalAddress { get; init; } = new ValueList<ModificationScope1>(){};
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QN5QENp-Ed-ak6NoX_4Aeg_-1024877605")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Primary Communication Address")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; } 
    #else
    public CommunicationAddress3? PrimaryCommunicationAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QN5QEdp-Ed-ak6NoX_4Aeg_1651485498")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Secondary Communication Address")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; } 
    #else
    public CommunicationAddress3? SecondaryCommunicationAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
