﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PercentageRate.  ISO2002 ID# _qCevQ65xEeeMy7TnJ3e__g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Quantity43Choice;

/// <summary>
/// Percentage rate of assets to be settled.
/// </summary>
public partial record PercentageRate : IQuantity43Choice
{
    public required IsoPercentageRate Value { get; init; }
}
