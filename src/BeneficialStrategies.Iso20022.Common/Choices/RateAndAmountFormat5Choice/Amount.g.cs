﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _UOCrwtp-Ed-ak6NoX_4Aeg_722186532.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat5Choice;

/// <summary>
/// Value is expressed as a currency and amount.
/// </summary>
public partial record Amount : IRateAndAmountFormat5Choice
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
