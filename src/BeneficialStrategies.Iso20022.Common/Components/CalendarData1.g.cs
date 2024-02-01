﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CalendarData1.  ISO2002 ID# _dVcQ04m7Eeipw6hHPgB4Sw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes information needed to identify a change for a static data, the time when it was performed and the user requesting the change and approving it.
/// </summary>
public partial record CalendarData1
{
    #nullable enable
    
    /// <summary>
    /// Date for which the calendar information is provided.
    /// </summary>
    public required IsoISODate SystemDate { get; init; } 
    /// <summary>
    /// Status of the system.
    /// </summary>
    public required SystemStatus3Choice_ SystemStatus { get; init; } 
    
    #nullable disable
}
