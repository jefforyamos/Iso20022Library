﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _iPVxI-XsEemEj48jhmlA0Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat39Choice;

/// <summary>
/// Number of monetary units specified in a currency.
/// </summary>
public partial record Amount : NetDividendRateFormat39Choice_
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
