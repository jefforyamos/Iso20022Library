﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _CCq1UeXsEemEj48jhmlA0Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat35Choice;

/// <summary>
/// Value expressed as an amount.
/// </summary>
public partial record Amount : GrossDividendRateFormat35Choice_
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
