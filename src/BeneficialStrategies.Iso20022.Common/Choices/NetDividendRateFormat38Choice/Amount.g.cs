﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _PVD4c-XsEemEj48jhmlA0Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat38Choice;

/// <summary>
/// Number of monetary units specified in a currency.
/// </summary>
public partial record Amount : INetDividendRateFormat38Choice
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
