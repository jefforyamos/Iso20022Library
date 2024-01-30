﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ClosingBalance3.  ISO2002 ID# _P_d9EznGEeWV5sr121Fc8A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
/// </summary>
public partial record ClosingBalance3
{
    #nullable enable
    
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    public required ShortLong1Code ShortLongIndicator { get; init; } 
    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    public required IClosingBalance4Choice ClosingBalance { get; init; } 
    
    #nullable disable
}
