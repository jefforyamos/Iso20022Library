﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndTrigger1.  ISO2002 ID# _-GTXZnltEeG7BsjMvd1mEw_-1985688302.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount and trigger information.
/// </summary>
public partial record AmountAndTrigger1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the amount and trigger details.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Choice between an amount and a percentage.
    /// </summary>
    public required IAmountOrPercentage1Choice AmountDetailsChoice { get; init; } 
    /// <summary>
    /// Trigger that causes the variation to come into effect.
    /// </summary>
    public Trigger1? Trigger { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
