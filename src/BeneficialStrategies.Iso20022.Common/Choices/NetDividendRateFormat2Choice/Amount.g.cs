﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _UM2Y99p-Ed-ak6NoX_4Aeg_-319728172.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat2Choice;

/// <summary>
/// Value expressed as an amount.
/// </summary>
public partial record Amount : NetDividendRateFormat2Choice_
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
