﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FixedInterestRate.  ISO2002 ID# _Qk1wc9p-Ed-ak6NoX_4Aeg_-824336406.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate1Choice;

/// <summary>
/// Indicates that the rate is fixed.
/// </summary>
public partial record FixedInterestRate : IInterestRate1Choice
{
    public required IsoPercentageRate Value { get; init; }
}
