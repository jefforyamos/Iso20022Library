﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SystemEvent3.  ISO2002 ID# _dw2Oi3hkEeidzqjNEfehPg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on an event occurring in a system, whether planned or unplanned as stipulated in the specifications of the system.
/// </summary>
public partial record SystemEvent3
{
    #nullable enable
    
    /// <summary>
    /// Nature of the event that has occurred.
    /// </summary>
    public required SystemEventType4Choice_ Type { get; init; } 
    /// <summary>
    /// Date and time at which the event is foreseen to occur.
    /// </summary>
    public required IsoISODateTime ScheduledTime { get; init; } 
    /// <summary>
    /// Date and time at which the event effectively takes place.
    /// </summary>
    public IsoISODateTime? EffectiveTime { get; init; } 
    /// <summary>
    /// Time at which the event starts.
    /// </summary>
    public IsoISODateTime? StartTime { get; init; } 
    /// <summary>
    /// Time at which the event ends.
    /// </summary>
    public IsoISODateTime? EndTime { get; init; } 
    
    #nullable disable
}
