﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _yZwPhzklEeapUO0vUIo9Xw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TaxAmountOrRate4Choice;

/// <summary>
/// Rate used to calculate the tax.
/// </summary>
public partial record Rate : ITaxAmountOrRate4Choice
{
    public required IsoPercentageRate Value { get; init; }
}
