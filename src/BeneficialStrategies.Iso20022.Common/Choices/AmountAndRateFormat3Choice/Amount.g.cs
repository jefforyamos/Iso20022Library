﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _UIFNtNp-Ed-ak6NoX_4Aeg_896081910.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AmountAndRateFormat3Choice;

/// <summary>
/// Number of monetary units specified in a currency.
/// </summary>
public partial record Amount : IAmountAndRateFormat3Choice
{
    public required IsoActiveCurrencyAndAmount Value { get; init; }
}
