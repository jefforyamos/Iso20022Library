﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _d3Bg8bQBEee1Ke-6rZgsrA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmount3Choice;

/// <summary>
/// Price expressed as a rate, that is percentage.
/// </summary>
public partial record Rate : IPriceRateOrAmount3Choice
{
    public required IsoPercentageRate Value { get; init; }
}
