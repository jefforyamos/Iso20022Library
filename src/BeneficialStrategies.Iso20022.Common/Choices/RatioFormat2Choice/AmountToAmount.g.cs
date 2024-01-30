﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountToAmount.  ISO2002 ID# _Rj3khdp-Ed-ak6NoX_4Aeg_1125895712.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat2Choice;

/// <summary>
/// The ratio is expressed as an amount per another amount.
/// </summary>
public partial record AmountToAmount : IRatioFormat2Choice
{
    #nullable enable
    /// <summary>
    /// Numerator of the quotient of amounts.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount1 { get; init; } 
    /// <summary>
    /// Denominator of the quotient of amounts.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount2 { get; init; } 
    #nullable disable
}
