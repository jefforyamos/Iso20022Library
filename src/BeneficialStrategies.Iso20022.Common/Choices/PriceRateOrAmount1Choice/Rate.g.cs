﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _Wi6RY9p-Ed-ak6NoX_4Aeg_756785354.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmount1Choice;

/// <summary>
/// Price expressed as a rate, that is, percentage.
/// </summary>
public partial record Rate : PriceRateOrAmount1Choice_
{
    public required IsoPercentageRate Value { get; init; }
}
