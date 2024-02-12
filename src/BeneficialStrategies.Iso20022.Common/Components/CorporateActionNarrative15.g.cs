﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNarrative15.  ISO2002 ID# _WZhE0dp-Ed-ak6NoX_4Aeg_319701841.
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
/// Provides additional information such as the taxation conditions.
/// </summary>
[IsoId("_WZhE0dp-Ed-ak6NoX_4Aeg_319701841")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action Narrative")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNarrative15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_WZhE0tp-Ed-ak6NoX_4Aeg_-1496324193")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Text")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation6? AdditionalText { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation6? AdditionalText { get; init; } 
    #else
    public UpdatedAdditionalInformation6? AdditionalText { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields of this message, - or narrative information not needed for automatic processing.
    /// </summary>
    [IsoId("_WZhE09p-Ed-ak6NoX_4Aeg_-78734890")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Narrative Version")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation6? NarrativeVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation6? NarrativeVersion { get; init; } 
    #else
    public UpdatedAdditionalInformation6? NarrativeVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    [IsoId("_WZhE1Np-Ed-ak6NoX_4Aeg_2108248634")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Information Conditions")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation5? InformationConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation5? InformationConditions { get; init; } 
    #else
    public UpdatedAdditionalInformation5? InformationConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    [IsoId("_WZhE1dp-Ed-ak6NoX_4Aeg_-730076701")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Information To Comply With")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation5? InformationToComplyWith { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation5? InformationToComplyWith { get; init; } 
    #else
    public UpdatedAdditionalInformation5? InformationToComplyWith { get; set; } 
    #endif
    
    /// <summary>
    /// Provides restriction(s) on securities.
    /// </summary>
    [IsoId("_WZhE1tp-Ed-ak6NoX_4Aeg_573673536")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Restriction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation5? SecurityRestriction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation5? SecurityRestriction { get; init; } 
    #else
    public UpdatedAdditionalInformation5? SecurityRestriction { get; set; } 
    #endif
    
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    [IsoId("_WZhE19p-Ed-ak6NoX_4Aeg_-1534310236")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Taxation Conditions")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation5? TaxationConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation5? TaxationConditions { get; init; } 
    #else
    public UpdatedAdditionalInformation5? TaxationConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    [IsoId("_WZhE2Np-Ed-ak6NoX_4Aeg_-230559999")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Disclaimer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UpdatedAdditionalInformation5? Disclaimer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UpdatedAdditionalInformation5? Disclaimer { get; init; } 
    #else
    public UpdatedAdditionalInformation5? Disclaimer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
