﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _fFh9EZSoEeeh5JjedkaA_g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat52Choice;

/// <summary>
/// Value is expressed as a currency and amount.
/// </summary>
public partial record Amount : RateAndAmountFormat52Choice_
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
