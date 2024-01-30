﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _7k007UEEEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat39Choice;

/// <summary>
/// Value is expressed as a currency and amount.
/// </summary>
public partial record Amount : IRateAndAmountFormat39Choice
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
