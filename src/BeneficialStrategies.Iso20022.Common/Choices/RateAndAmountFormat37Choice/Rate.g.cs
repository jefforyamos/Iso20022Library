﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _qPQ3RUEEEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat37Choice;

/// <summary>
/// Value expressed as a rate.
/// </summary>
public partial record Rate : IRateAndAmountFormat37Choice
{
    public required IsoPercentageRate Value { get; init; }
}
