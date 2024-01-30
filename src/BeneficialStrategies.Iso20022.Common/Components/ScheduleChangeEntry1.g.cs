﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ScheduleChangeEntry1.  ISO2002 ID# _bMr9gBkcEeapYKOltfjd7A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about the schedule change.
/// </summary>
public partial record ScheduleChangeEntry1
{
    #nullable enable
    
    /// <summary>
    /// Type of the scheduled event.
    /// </summary>
    public required ISystemEventType2Choice ScheduleEventType { get; init; } 
    /// <summary>
    /// Identificaiton of the scheduled event.
    /// </summary>
    public IsoExact1NumericText? ScheduleEventIdentification { get; init; } 
    /// <summary>
    /// New frequency of the scheduled event.
    /// </summary>
    public IsoMax4Text? EventFrequency { get; init; } 
    /// <summary>
    /// Frequency of the scheduled event before change.
    /// </summary>
    public IsoMax4Text? EventPreviousFrequency { get; init; } 
    /// <summary>
    /// New scheduled time of the event.
    /// </summary>
    public IsoISOTime? EventTime { get; init; } 
    /// <summary>
    /// Scheduled time of the event before change.
    /// </summary>
    public IsoISOTime? EventPreviousTime { get; init; } 
    /// <summary>
    /// Minimum duration of event.
    /// </summary>
    public IsoMax3NumericText? EventDuration { get; init; } 
    /// <summary>
    /// Set earlier duration of event.
    /// </summary>
    public IsoMax3NumericText? EventPreviousDuration { get; init; } 
    /// <summary>
    /// Type of schedule modification (i.e. event cancelled, new event).
    /// </summary>
    public required IsoMax35Text ChangeType { get; init; } 
    
    #nullable disable
}
