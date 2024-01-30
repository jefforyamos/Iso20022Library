﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _637-sewOEd-sn-FiNtktcA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat15Choice;

/// <summary>
/// Number of monetary units specified in a currency.
/// </summary>
public partial record Amount : IRateAndAmountFormat15Choice
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
