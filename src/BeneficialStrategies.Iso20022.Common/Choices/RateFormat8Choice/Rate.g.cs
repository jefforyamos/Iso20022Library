﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _VA1A3BLtEeKJ5uSjVyVvug.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateFormat8Choice;

/// <summary>
/// Value is expressed as a rate.
/// </summary>
public partial record Rate : RateFormat8Choice_
{
    public required IsoPercentageRate Value { get; init; }
}
