﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _UNAJ8dp-Ed-ak6NoX_4Aeg_240719178.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InterestRateUsedForPaymentFormat2Choice;

/// <summary>
/// Number of monetary units specified in a currency.
/// </summary>
public partial record Amount : IInterestRateUsedForPaymentFormat2Choice
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
