﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Percentage.  ISO2002 ID# _MXso481VEem4K5qLxnWwMA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice11Choice;

/// <summary>
/// Price expressed as a rate, that is a percentage.
/// </summary>
public partial record Percentage : ISecuritiesTransactionPrice11Choice
{
    public required IsoPercentageRate Value { get; init; }
}
