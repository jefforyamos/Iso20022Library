﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionGeneralInformationSD29.  ISO2002 ID# _mRLVcb5XEeexmbB7KsjCwA.
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
[IsoId("_mRLVcb5XEeexmbB7KsjCwA")]
[DisplayName("Corporate Action General Information SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionGeneralInformationSD29
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
    [IsoId("_mh_Yob5XEeexmbB7KsjCwA")]
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
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action event type name. Used in place for the events that cannot be classified by ISO Code and are marked as OTHR. Can be used in combination with DTCC sub event type (when provided) to identify the event. For an example: a distribution based on recapitalisation event will be presented as event type: OTHR in standard message. DTCC native event type would be Distribution (DIST) and DTCC sub event type would be Recapitalisation.
    /// </summary>
    [IsoId("_mh_Yo75XEeexmbB7KsjCwA")]
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
    /// DTCC (The Depository Trust and Clearing Corporation) corporate action sub event type name further defines the event type. For an example: a cash dividend event eligible for dividend reinvestment at DTC election will be noted as event type: cash dividend (DVCA) and DTCC sub event type: DRIP( DTC only).
    /// </summary>
    [IsoId("_mh_Yq75XEeexmbB7KsjCwA")]
    [DisplayName("Sub Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubEvtTp")]
    #endif
    [IsoXmlTag("SubEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCCSubEventType6Code? SubEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCCSubEventType6Code? SubEventType { get; init; } 
    #else
    public DTCCSubEventType6Code? SubEventType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
