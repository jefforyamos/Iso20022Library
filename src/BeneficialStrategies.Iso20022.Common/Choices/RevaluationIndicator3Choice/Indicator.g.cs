﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Indicator.  ISO2002 ID# _CQyt4Tw0EeW3QqUkIQtIUA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RevaluationIndicator3Choice;

/// <summary>
/// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
/// </summary>
public partial record Indicator : RevaluationIndicator3Choice_
{
    public required IsoYesNoIndicator Value { get; init; }
}
