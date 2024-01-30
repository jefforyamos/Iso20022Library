﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _8le6IANhEe2-vqzwMUAewg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CurrencyOrDigitalTokenAmount1Choice;

/// <summary>
/// Amount specified as an ISO currency (ISO 4217).
/// </summary>
public partial record Amount : ICurrencyOrDigitalTokenAmount1Choice
{
    public required IsoActiveOrHistoricCurrencyAndAmount Value { get; init; }
}
