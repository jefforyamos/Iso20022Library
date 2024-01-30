﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountToAmount.  ISO2002 ID# _g3oeg-wOEd-sn-FiNtktcA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat12Choice;

/// <summary>
/// Ratio expressed as a quotient of amounts.
/// </summary>
public partial record AmountToAmount : IRatioFormat12Choice
{
    #nullable enable
    /// <summary>
    /// Numerator of the quotient of amounts.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Amount1 { get; init; } 
    /// <summary>
    /// Denominator of the quotient of amounts.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Amount2 { get; init; } 
    #nullable disable
}
