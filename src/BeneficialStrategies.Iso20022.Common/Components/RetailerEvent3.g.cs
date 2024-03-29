﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RetailerEvent3.  ISO2002 ID# _Cnm_wS8SEeu125Ip9zFcsQ.
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
/// Content of the Retailer Event message.
/// </summary>
[IsoId("_Cnm_wS8SEeu125Ip9zFcsQ")]
[DisplayName("Retailer Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RetailerEvent3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RetailerEvent3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RetailerEvent3( System.DateTime reqEventTimeStamp,EventToNotify2Code reqEventToNotify )
    {
        EventTimeStamp = reqEventTimeStamp;
        EventToNotify = reqEventToNotify;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time of the event.
    /// </summary>
    [IsoId("_CzHsMS8SEeu125Ip9zFcsQ")]
    [DisplayName("Event Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTmStmp")]
    #endif
    [IsoXmlTag("EvtTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime EventTimeStamp { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime EventTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime EventTimeStamp { get; init; } 
    #else
    public System.DateTime EventTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Event the POI notifies to the Sale System.
    /// </summary>
    [IsoId("_CzHsMy8SEeu125Ip9zFcsQ")]
    [DisplayName("Event To Notify")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtToNtfy")]
    #endif
    [IsoXmlTag("EvtToNtfy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EventToNotify2Code EventToNotify { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EventToNotify2Code EventToNotify { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventToNotify2Code EventToNotify { get; init; } 
    #else
    public EventToNotify2Code EventToNotify { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the Event message.
    /// </summary>
    [IsoId("_CzHsNS8SEeu125Ip9zFcsQ")]
    [DisplayName("Event Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtCntxt")]
    #endif
    [IsoXmlTag("EvtCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EventContext3? EventContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventContext3? EventContext { get; init; } 
    #else
    public EventContext3? EventContext { get; set; } 
    #endif
    
    /// <summary>
    /// Additional Information according to the event type.
    /// </summary>
    [IsoId("_CzHsNy8SEeu125Ip9zFcsQ")]
    [DisplayName("Additional Event Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlEvtInf")]
    #endif
    [IsoXmlTag("AddtlEvtInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? AdditionalEventInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalEventInformation { get; init; } 
    #else
    public System.String? AdditionalEventInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
