﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _XFqMXUEIEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxCreditRateFormat8Choice;

/// <summary>
/// Number of monetary units specified in a currency.
/// </summary>
public partial record Amount : TaxCreditRateFormat8Choice_
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
