﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _jASs8eXsEemEj48jhmlA0Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat40Choice;

/// <summary>
/// Value expressed as an amount.
/// </summary>
public partial record Amount : INetDividendRateFormat40Choice
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
