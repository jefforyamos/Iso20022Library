﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _apaPUBLsEeKJ5uSjVyVvug.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SolicitationFeeRateFormat5Choice;

/// <summary>
/// Cash amount.
/// </summary>
public partial record Amount : ISolicitationFeeRateFormat5Choice
{
    public required IsoActiveCurrencyAnd13DecimalAmount Value { get; init; }
}
