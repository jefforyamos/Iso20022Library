﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ClearingControlTotals1.  ISO2002 ID# _7vrLEFA9EeedyPuM0kK2EQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Gross clearing control totals.
/// </summary>
public partial record ClearingControlTotals1
{
    #nullable enable
    
    /// <summary>
    /// Number of clearing transactions. To be used for control purpose.
    /// </summary>
    public required IsoNumber ClearingControlCount { get; init; } 
    /// <summary>
    /// Gross accumulated amount of clearing. To be used for control purpose.
    /// </summary>
    public required Amount14 ClearingControlAmount { get; init; } 
    
    #nullable disable
}
