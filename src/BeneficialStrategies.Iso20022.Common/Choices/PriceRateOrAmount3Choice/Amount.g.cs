﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _d3Bg87QBEee1Ke-6rZgsrA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmount3Choice;

/// <summary>
/// Price expressed as a currency and value.
/// </summary>
public partial record Amount : IPriceRateOrAmount3Choice
{
    public required IsoActiveOrHistoricCurrencyAnd13DecimalAmount Value { get; init; }
}
