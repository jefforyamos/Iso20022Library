﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification251.  ISO2002 ID# _IDLG6RuyEeyhRdHRjakS2w.
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
/// Provides information about the beneficial owner of the securities.
/// </summary>
[IsoId("_IDLG6RuyEeyhRdHRjakS2w")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Party Identification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification251
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification251 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification251( PartyIdentification229Choice_ reqOwnerIdentification,FinancialInstrumentQuantity33Choice_ reqOwnedSecuritiesQuantity )
    {
        OwnerIdentification = reqOwnerIdentification;
        OwnedSecuritiesQuantity = reqOwnedSecuritiesQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that is the beneficial owner of the specified quantity of securities.
    /// </summary>
    [IsoId("_IYCjlRuyEeyhRdHRjakS2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Owner Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification229Choice_ OwnerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PartyIdentification229Choice_ OwnerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification229Choice_ OwnerIdentification { get; init; } 
    #else
    public PartyIdentification229Choice_ OwnerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Legal entity identification of the party.
    /// </summary>
    [IsoId("_IYCjnRuyEeyhRdHRjakS2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("LEI Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? LEIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LEIIdentification { get; init; } 
    #else
    public System.String? LEIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_IYCjnxuyEeyhRdHRjakS2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Alternate Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
    #else
    public AlternatePartyIdentification7? AlternateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which a person is permanently domiciled (the place of a person's permanent home).
    /// </summary>
    [IsoId("_IYCjpxuyEeyhRdHRjakS2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Domicile Country")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? DomicileCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? DomicileCountry { get; init; } 
    #else
    public string? DomicileCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Holder of the security certifies, in line with the terms of the corporate action, that it is not domiciled in the country indicated.
    /// </summary>
    [IsoId("_IYCjrxuyEeyhRdHRjakS2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Non Domicile Country")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? NonDomicileCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? NonDomicileCountry { get; init; } 
    #else
    public string? NonDomicileCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities belonging to the beneficial owner specified.
    /// </summary>
    [IsoId("_IYCjtxuyEeyhRdHRjakS2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Owned Securities Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity33Choice_ OwnedSecuritiesQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public FinancialInstrumentQuantity33Choice_ OwnedSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity33Choice_ OwnedSecuritiesQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity33Choice_ OwnedSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_IYCjvxuyEeyhRdHRjakS2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Certification Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficiaryCertificationType10Choice_? CertificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficiaryCertificationType10Choice_? CertificationType { get; init; } 
    #else
    public BeneficiaryCertificationType10Choice_? CertificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Requested percentage of a cash distribution that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_IYCjxxuyEeyhRdHRjakS2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Withholding Tax Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat37Choice_? WithholdingTaxRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat37Choice_? WithholdingTaxRate { get; init; } 
    #else
    public RateAndAmountFormat37Choice_? WithholdingTaxRate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    [IsoId("_IYCjyRuyEeyhRdHRjakS2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Certification Breakdown")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? CertificationBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificationBreakdown { get; init; } 
    #else
    public System.String? CertificationBreakdown { get; set; } 
    #endif
    
    
    #nullable disable
    
}
