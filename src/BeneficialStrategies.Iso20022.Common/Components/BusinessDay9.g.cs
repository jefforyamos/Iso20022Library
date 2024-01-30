﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BusinessDay9.  ISO2002 ID# _OYVo5XXyEei3jO6riKEVXg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment system operational information, such as opening, closure, session period or events, given per currency.
/// </summary>
public partial record BusinessDay9
{
    #nullable enable
    
    /// <summary>
    /// Date for which the availability information is provided.
    /// </summary>
    public IDateAndDateTime2Choice? SystemDate { get; init; } 
    /// <summary>
    /// Status of a system and the period of time during which the status is valid.
    /// </summary>
    public SystemStatus3? SystemStatus { get; init; } 
    /// <summary>
    /// Information relating to system operations and foreseen events relating to the operation of the system.
    /// </summary>
    public SystemAvailabilityAndEvents3? SystemInformationPerCurrency { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
