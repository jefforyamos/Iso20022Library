﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _chezlZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat43Choice;

/// <summary>
/// Value is expressed as a rate.
/// </summary>
public partial record Rate : IRateAndAmountFormat43Choice
{
    public required IsoPercentageRate Value { get; init; }
}
