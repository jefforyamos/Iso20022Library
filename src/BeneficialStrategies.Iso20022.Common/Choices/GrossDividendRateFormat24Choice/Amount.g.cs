﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _ckMw45KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat24Choice;

/// <summary>
/// Value expressed as an amount.
/// </summary>
public partial record Amount : GrossDividendRateFormat24Choice_
{
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
