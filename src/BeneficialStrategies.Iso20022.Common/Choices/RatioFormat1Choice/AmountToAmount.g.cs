﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountToAmount.  ISO2002 ID# _Rj3kgdp-Ed-ak6NoX_4Aeg_-251071667.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat1Choice;

/// <summary>
/// The ratio is expressed as an amount per another amount.
/// </summary>
public partial record AmountToAmount : RatioFormat1Choice_
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
