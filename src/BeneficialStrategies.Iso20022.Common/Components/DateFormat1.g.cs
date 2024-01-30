﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DateFormat1.  ISO2002 ID# __ZsXMFuSEeSmO6RkXg92Lg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Format to express a date and a date mode.
/// </summary>
public partial record DateFormat1
{
    #nullable enable
    
    /// <summary>
    /// Date at which the event occurs.
    /// </summary>
    public required IDateFormat3Choice Date { get; init; } 
    /// <summary>
    /// Specifies whether an event for which a date is provided occurs typically at the "beginning of day" or at the "end of day".
    /// </summary>
    public DateMode1Code? DateMode { get; init; } 
    
    #nullable disable
}
