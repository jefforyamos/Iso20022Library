﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedRate.  ISO2002 ID# _fejJDggYEeCVlvYcV4HKqQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat13Choice;

/// <summary>
/// Value of the ratio not specified.
/// </summary>
public partial record NotSpecifiedRate : IRatioFormat13Choice
{
    public required RateValueType7Code Value { get; init; }
}
