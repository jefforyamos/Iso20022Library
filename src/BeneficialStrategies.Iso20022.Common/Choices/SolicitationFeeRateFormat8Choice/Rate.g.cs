﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _NlMN1mNZEeW4z96Yfj3Wng.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SolicitationFeeRateFormat8Choice;

/// <summary>
/// Value is expressed as a rate.
/// </summary>
public partial record Rate : SolicitationFeeRateFormat8Choice_
{
    public required IsoPercentageRate Value { get; init; }
}
