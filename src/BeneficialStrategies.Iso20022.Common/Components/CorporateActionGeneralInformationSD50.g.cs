﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformationSD50.  ISO2002 ID# _ZDw9QTDrEey2N-DB7H7A5A.
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
[IsoId("_ZDw9QTDrEey2N-DB7H7A5A")]
[DisplayName("Corporate Action General Information SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionGeneralInformationSD50
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
    [IsoId("_ZYU4ATDrEey2N-DB7H7A5A")]
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
    [IsoId("_ZYU4AzDrEey2N-DB7H7A5A")]
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
    [IsoId("_ZYU4CzDrEey2N-DB7H7A5A")]
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
    [IsoId("_ZYU4EzDrEey2N-DB7H7A5A")]
    [DisplayName("Sub Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubEvtTp")]
    #endif
    [IsoXmlTag("SubEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCCSubEventType9Code? SubEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCCSubEventType9Code? SubEventType { get; init; } 
    #else
    public DTCCSubEventType9Code? SubEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique number systemically assigned to all lottery and non-lottery events announced in DTC redemptions (REDS) participant terminal system (PTS) / participant browser system (PBS) function.
    /// </summary>
    [IsoId("_ZYU4GzDrEey2N-DB7H7A5A")]
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
    
    
    #nullable disable
    
}
