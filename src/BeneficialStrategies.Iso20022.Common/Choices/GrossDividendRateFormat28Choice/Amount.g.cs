﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _0XASMZb7Eee8S7xwGG7Veg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat28Choice;

/// <summary>
/// Value expressed as an amount.
/// </summary>
public partial record Amount : IGrossDividendRateFormat28Choice
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
