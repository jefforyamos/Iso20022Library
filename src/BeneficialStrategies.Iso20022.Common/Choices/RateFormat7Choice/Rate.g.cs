﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _8_swB_maEeCgTOP8zvX1cw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateFormat7Choice;

/// <summary>
/// Value is expressed as a rate.
/// </summary>
public partial record Rate : RateFormat7Choice_
{
    public required IsoPercentageRate Value { get; init; }
}
