﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PercentageAndPeriod1.  ISO2002 ID# _OTgzMzg0-AOSNFX-8224502.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a percentage together with a period of time. For overlapping periods, the maximum of all applicable elements at a given date is the result.
/// </summary>
public partial record PercentageAndPeriod1
{
    #nullable enable
    
    /// <summary>
    /// Covered percentage (max 100%).
    /// </summary>
    public required IsoPercentageBoundedRate Percentage { get; init; } 
    /// <summary>
    /// Start of period or immediate if not specified.
    /// </summary>
    public IsoISODate? StartDate { get; init; } 
    /// <summary>
    /// End of period or indefinite if not specified.
    /// </summary>
    public IsoISODate? EndDate { get; init; } 
    
    #nullable disable
}
