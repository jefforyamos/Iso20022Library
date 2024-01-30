﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProcessRetry3.  ISO2002 ID# _M4Y0sTASEeugIJ3Gvoevmg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Definition of retry process if activation of an action fails.
/// </summary>
public partial record ProcessRetry3
{
    #nullable enable
    
    /// <summary>
    /// Time period to wait for a retry in months, days, hours and minutes, leading zeros could be omitted.
    /// </summary>
    public required IsoMax9NumericText Delay { get; init; } 
    /// <summary>
    /// Maximum number of retries.
    /// </summary>
    public IsoNumber? MaximumNumber { get; init; } 
    /// <summary>
    /// Identification of the minimum unit of time used by time configuration parameters.
    /// </summary>
    public TimeUnit1Code? UnitOfTime { get; init; } 
    
    #nullable disable
}
