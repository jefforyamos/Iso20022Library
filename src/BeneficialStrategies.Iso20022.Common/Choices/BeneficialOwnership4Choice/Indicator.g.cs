﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Indicator.  ISO2002 ID# _T5OZkTqGEeWVrPy0StzzSg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.BeneficialOwnership4Choice;

/// <summary>
/// Specifies whether there is change of beneficial ownership.
/// </summary>
public partial record Indicator : IBeneficialOwnership4Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
