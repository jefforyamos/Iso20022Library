﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _baDKgwVTEeqjd8n6wD9JVw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat44Choice;

/// <summary>
/// Number of monetary units specified in a currency.
/// </summary>
public partial record Amount : NetDividendRateFormat44Choice_
{
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
