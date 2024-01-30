﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Adjustment11.  ISO2002 ID# _wd8wXPNGEei4qfiLgRIZBA.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes each adjustment made to the original price.
/// </summary>
public partial record Adjustment11
{
    #nullable enable
    
    /// <summary>
    /// Contains the adjusted amount (for example, discounts).
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates whether or not the line item is a credit amount.
    /// </summary>
    public IsoTrueFalseIndicator? CreditIndicator { get; init; } 
    /// <summary>
    /// Reason for the adjustment.
    /// </summary>
    public IsoMax35Text? Reason { get; init; } 
    
    #nullable disable
}
