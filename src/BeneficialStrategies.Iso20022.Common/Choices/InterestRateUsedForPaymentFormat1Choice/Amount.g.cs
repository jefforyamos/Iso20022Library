﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _UOySo9p-Ed-ak6NoX_4Aeg_-1208255471.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRateUsedForPaymentFormat1Choice;

/// <summary>
/// Number of monetary units specified in a currency.
/// </summary>
public partial record Amount : IInterestRateUsedForPaymentFormat1Choice
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
