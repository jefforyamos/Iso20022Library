﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RetailerEvent4.  ISO2002 ID# _QV5csVFBEeyApZmLzm74zA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Retailer Event message.
/// </summary>
public partial record RetailerEvent4
{
    #nullable enable
    
    /// <summary>
    /// Date and time of the event.
    /// </summary>
    public required IsoISODateTime EventTimeStamp { get; init; } 
    /// <summary>
    /// Event the POI notifies to the Sale System.
    /// </summary>
    public required EventToNotify2Code EventToNotify { get; init; } 
    /// <summary>
    /// Context of the Event message.
    /// </summary>
    public EventContext4? EventContext { get; init; } 
    /// <summary>
    /// Additional Information according to the event type.
    /// </summary>
    public IsoMax1025Text? AdditionalEventInformation { get; init; } 
    
    #nullable disable
}
