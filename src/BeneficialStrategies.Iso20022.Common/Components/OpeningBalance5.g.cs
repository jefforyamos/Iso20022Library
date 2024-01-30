﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OpeningBalance5.  ISO2002 ID# __ZNdESp7EeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
/// </summary>
public partial record OpeningBalance5
{
    #nullable enable
    
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    public required ShortLong1Code ShortLongIndicator { get; init; } 
    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    public required IOpeningBalance6Choice OpeningBalance { get; init; } 
    
    #nullable disable
}
