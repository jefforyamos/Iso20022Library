﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _UPF0qNp-Ed-ak6NoX_4Aeg_918914454.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RateFormat5Choice;

/// <summary>
/// Value is expressed as a rate.
/// </summary>
public partial record Rate : IRateFormat5Choice
{
    public required IsoPercentageRate Value { get; init; }
}
