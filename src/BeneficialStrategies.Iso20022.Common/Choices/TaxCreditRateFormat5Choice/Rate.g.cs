﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _DeFVIewPEd-sn-FiNtktcA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TaxCreditRateFormat5Choice;

/// <summary>
/// Value is expressed as a rate.
/// </summary>
public partial record Rate : ITaxCreditRateFormat5Choice
{
    public required IsoPercentageRate Value { get; init; }
}
