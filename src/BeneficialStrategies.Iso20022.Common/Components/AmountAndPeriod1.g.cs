﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndPeriod1.  ISO2002 ID# _OTgzMzgw-AOSNFX-8224502.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Relates an amount to a period of time.
/// </summary>
public partial record AmountAndPeriod1
{
    #nullable enable
    
    /// <summary>
    /// Amount of this period.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
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
