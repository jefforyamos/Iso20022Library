﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _te5_oQauEeS3lpTattq7hg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountOrRate3Choice;

/// <summary>
/// Amount of money.
/// </summary>
public partial record Amount : AmountOrRate3Choice_
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
