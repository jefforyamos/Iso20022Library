﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Percentage.  ISO2002 ID# _gSTIhZjcEeqkLZLH6DK3UQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice17Choice;

/// <summary>
/// Indicates that price is expressed as a rate, that is a percentage.
/// </summary>
public partial record Percentage : ISecuritiesTransactionPrice17Choice
{
    public required IsoPercentageRate Value { get; init; }
}
