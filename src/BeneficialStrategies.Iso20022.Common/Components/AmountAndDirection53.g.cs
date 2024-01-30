﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndDirection53.  ISO2002 ID# _smvlckDXEeWOL-OsSq2h6w.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money expressed with an optional currency code and debit/credit indicator.
/// </summary>
public partial record AmountAndDirection53
{
    #nullable enable
    
    /// <summary>
    /// Amount of money that results in an increase (positively signed) or decrease (negatively signed), with specification of the currency.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates that the amount value is positive or negative.
    /// Usage: When absent, the amount is positive.
    /// </summary>
    public IsoPlusOrMinusIndicator? Sign { get; init; } 
    
    #nullable disable
}
