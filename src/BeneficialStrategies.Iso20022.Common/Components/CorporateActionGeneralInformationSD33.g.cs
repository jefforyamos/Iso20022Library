﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformationSD33.  ISO2002 ID# _g9dp8eaNEei5aPS232E3Mw.
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
/// Provides additional information regarding corporate action general information details.
/// </summary>
[IsoId("_g9dp8eaNEei5aPS232E3Mw")]
[DisplayName("Corporate Action General Information SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionGeneralInformationSD33
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_hj2Ug-aNEei5aPS232E3Mw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// DTC processing domain/ category for event types.
    /// </summary>
    [IsoId("_hj2UheaNEei5aPS232E3Mw")]
    [DisplayName("Event Group")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtGrp")]
    #endif
    [IsoXmlTag("EvtGrp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EventGroup1Code? EventGroup { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventGroup1Code? EventGroup { get; init; } 
    #else
    public EventGroup1Code? EventGroup { get; set; } 
    #endif
    
    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action event type name. Used in place for the events that cannot be classified by ISO code and mapped to OTHR or when two or more distinct events (in DTCC model) use same ISO code and there are no additional data elements that distinguish those two or more events.
    /// </summary>
    [IsoId("_hj2UjeaNEei5aPS232E3Mw")]
    [DisplayName("Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTp")]
    #endif
    [IsoXmlTag("EvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExtendedEventType6Code? EventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExtendedEventType6Code? EventType { get; init; } 
    #else
    public ExtendedEventType6Code? EventType { get; set; } 
    #endif
    
    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action sub event type name further defines the event type.
    /// </summary>
    [IsoId("_hj2UleaNEei5aPS232E3Mw")]
    [DisplayName("Sub Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubEvtTp")]
    #endif
    [IsoXmlTag("SubEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCCSubEventType7Code? SubEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCCSubEventType7Code? SubEventType { get; init; } 
    #else
    public DTCCSubEventType7Code? SubEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the event is eligible for Elective Dividend Services instruction messaging or voluntary reorganization instruction messaging.
    /// </summary>
    [IsoId("_hj2UneaNEei5aPS232E3Mw")]
    [DisplayName("Instruction Messaging Eligibility Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrMsggElgbltyFlg")]
    #endif
    [IsoXmlTag("InstrMsggElgbltyFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? InstructionMessagingEligibilityFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionMessagingEligibilityFlag { get; init; } 
    #else
    public System.String? InstructionMessagingEligibilityFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Unique number systemically assigned to all lottery and non-lottery events announced in DTC redemptions (REDS) participant terminal system (PTS)/ participant browser system(PBS) function.
    /// </summary>
    [IsoId("_hj2Un-aNEei5aPS232E3Mw")]
    [DisplayName("Redemption Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedId")]
    #endif
    [IsoXmlTag("RedId")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumericText? RedemptionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RedemptionIdentification { get; init; } 
    #else
    public System.String? RedemptionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies events that offer instruction processing specific to foreign currency payment (FCP) elections.
    /// </summary>
    [IsoId("_hj2UoeaNEei5aPS232E3Mw")]
    [DisplayName("DTCFCP Election Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCFCPElctnFlg")]
    #endif
    [IsoXmlTag("DTCFCPElctnFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DTCFCPElectionFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DTCFCPElectionFlag { get; init; } 
    #else
    public System.String? DTCFCPElectionFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the event is being processed by DTC.
    /// </summary>
    [IsoId("_hj2Uo-aNEei5aPS232E3Mw")]
    [DisplayName("Asset Servicer Processing Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstSvcrPrcgFlg")]
    #endif
    [IsoXmlTag("AsstSvcrPrcgFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AssetServicerProcessingFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssetServicerProcessingFlag { get; init; } 
    #else
    public System.String? AssetServicerProcessingFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
