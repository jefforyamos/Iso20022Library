﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _fNHaxAgYEeCVlvYcV4HKqQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat16Choice;

/// <summary>
/// Value expressed as a rate.
/// </summary>
public partial record Rate : IRateAndAmountFormat16Choice
{
    public required IsoPercentageRate Value { get; init; }
}
