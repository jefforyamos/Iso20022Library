﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _uF0bEa8wEee2P-j6wtfM2A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateFormat22Choice;

/// <summary>
/// Cash amount.
/// </summary>
public partial record Amount : IRateFormat22Choice
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
