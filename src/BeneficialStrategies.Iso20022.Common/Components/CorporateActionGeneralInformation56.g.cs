﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformation56.  ISO2002 ID# _0lj38REuEeKp2ZN13DI_pA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// General information about the corporate action event.
/// </summary>
[IsoId("_0lj38REuEeKp2ZN13DI_pA")]
[DisplayName("Corporate Action General Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionGeneralInformation56
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionGeneralInformation56 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionGeneralInformation56( System.String reqCorporateActionEventIdentification,CorporateActionEventType13Choice_ reqEventType,CorporateActionMandatoryVoluntary1Choice_ reqMandatoryVoluntaryEventType,SecurityIdentification14 reqFinancialInstrumentIdentification )
    {
        CorporateActionEventIdentification = reqCorporateActionEventIdentification;
        EventType = reqEventType;
        MandatoryVoluntaryEventType = reqMandatoryVoluntaryEventType;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_07BxuhEuEeKp2ZN13DI_pA")]
    [DisplayName("Corporate Action Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnEvtId")]
    #endif
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CorporateActionEventIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CorporateActionEventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CorporateActionEventIdentification { get; init; } 
    #else
    public System.String CorporateActionEventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Official and unique reference assigned by the official central body/entity within each market at the beginning of a corporate action event.
    /// </summary>
    [IsoId("_07BxxxEuEeKp2ZN13DI_pA")]
    [DisplayName("Official Corporate Action Event Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OffclCorpActnEvtId")]
    #endif
    [IsoXmlTag("OffclCorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OfficialCorporateActionEventIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OfficialCorporateActionEventIdentification { get; init; } 
    #else
    public System.String? OfficialCorporateActionEventIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned by a court to a class action.
    /// </summary>
    [IsoId("_07Bx1BEuEeKp2ZN13DI_pA")]
    [DisplayName("Class Action Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssActnNb")]
    #endif
    [IsoXmlTag("ClssActnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClassActionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassActionNumber { get; init; } 
    #else
    public System.String? ClassActionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Type of corporate action event.
    /// </summary>
    [IsoId("_07Bx4REuEeKp2ZN13DI_pA")]
    [DisplayName("Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTp")]
    #endif
    [IsoXmlTag("EvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionEventType13Choice_ EventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionEventType13Choice_ EventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventType13Choice_ EventType { get; init; } 
    #else
    public CorporateActionEventType13Choice_ EventType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [IsoId("_07Bx7hEuEeKp2ZN13DI_pA")]
    [DisplayName("Mandatory Voluntary Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtryVlntryEvtTp")]
    #endif
    [IsoXmlTag("MndtryVlntryEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionMandatoryVoluntary1Choice_ MandatoryVoluntaryEventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionMandatoryVoluntary1Choice_ MandatoryVoluntaryEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMandatoryVoluntary1Choice_ MandatoryVoluntaryEventType { get; init; } 
    #else
    public CorporateActionMandatoryVoluntary1Choice_ MandatoryVoluntaryEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the security concerned by the corporate action.
    /// </summary>
    [IsoId("_07Bx-xEuEeKp2ZN13DI_pA")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
