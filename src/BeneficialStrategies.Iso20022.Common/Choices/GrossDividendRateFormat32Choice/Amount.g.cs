﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _sk1gpc3wEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat32Choice;

/// <summary>
/// Value expressed as an amount.
/// </summary>
public partial record Amount : IGrossDividendRateFormat32Choice
{
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
