﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _UNAJ99p-Ed-ak6NoX_4Aeg_1829064661.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat2Choice;

/// <summary>
/// Value expressed as an amount.
/// </summary>
public partial record Amount : IGrossDividendRateFormat2Choice
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
