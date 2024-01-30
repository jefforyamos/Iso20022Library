﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Indicator.  ISO2002 ID# _5mw3_5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RevaluationIndicator4Choice;

/// <summary>
/// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
/// </summary>
public partial record Indicator : IRevaluationIndicator4Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
