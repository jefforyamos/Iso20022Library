﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _S4q7ESeKEeOXAt_43VmZGw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat20Choice;

/// <summary>
/// Value expressed as a rate.
/// </summary>
public partial record Rate : IRateAndAmountFormat20Choice
{
    public required IsoPercentageRate Value { get; init; }
}
