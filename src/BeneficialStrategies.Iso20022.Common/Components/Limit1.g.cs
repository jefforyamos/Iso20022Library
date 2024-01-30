﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Limit1.  ISO2002 ID# _RJpGpNp-Ed-ak6NoX_4Aeg_-234268618.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the number of occurrences of a particular event and the maximum number of times this event may occur.
/// </summary>
public partial record Limit1
{
    #nullable enable
    
    /// <summary>
    /// Number of occurrences of a particular event.
    /// </summary>
    public required IsoMax3NumericText Current { get; init; } 
    /// <summary>
    /// Specifies the maximum number of times an event may occur.
    /// </summary>
    public required IsoMax3NumericText Limit { get; init; } 
    
    #nullable disable
}
