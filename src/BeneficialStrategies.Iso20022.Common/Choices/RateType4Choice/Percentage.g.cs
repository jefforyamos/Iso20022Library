﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Percentage.  ISO2002 ID# _Rp-zktp-Ed-ak6NoX_4Aeg_-171033889.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType4Choice;

/// <summary>
/// Ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
/// </summary>
public partial record Percentage : RateType4Choice_
{
    public required IsoPercentageRate Value { get; init; }
}
