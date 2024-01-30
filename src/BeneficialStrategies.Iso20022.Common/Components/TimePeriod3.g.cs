﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TimePeriod3.  ISO2002 ID# _r8aHYVo6Ee23K4GXSpBSeg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Particular time span specified between a start time and an end time. The time period cannot exceed 24 hours.
/// </summary>
public partial record TimePeriod3
{
    #nullable enable
    
    /// <summary>
    /// Time at which the time span starts.
    /// </summary>
    public IsoISOTime? FromTime { get; init; } 
    /// <summary>
    /// Time at which the time span ends.
    /// </summary>
    public IsoISOTime? ToTime { get; init; } 
    
    #nullable disable
}
