﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PercentageRate.  ISO2002 ID# _QYSGiRgKEeKqWJINzXcn5g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Quantity14Choice;

/// <summary>
/// Percentage rate of assets to be settled.
/// </summary>
public partial record PercentageRate : IQuantity14Choice
{
    public required IsoPercentageRate Value { get; init; }
}
