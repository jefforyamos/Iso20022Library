﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _Q-Unctp-Ed-ak6NoX_4Aeg_827689641.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountOrRate1Choice;

/// <summary>
/// Amount expressed as a rate.
/// </summary>
public partial record Rate : AmountOrRate1Choice_
{
    public required IsoPercentageRate Value { get; init; }
}
