﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Indicator.  ISO2002 ID# _Q-eYddp-Ed-ak6NoX_4Aeg_180533022.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Revaluation1Choice;

/// <summary>
/// Revaluation is determined using a yes/no indicator.
/// </summary>
public partial record Indicator : IRevaluation1Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
