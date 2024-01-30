﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Indicator.  ISO2002 ID# _Io5B4T0EEeWjqIDN7tjEjQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FXCancellation3Choice;

/// <summary>
/// Specifies whether the underlying forex transaction should also be cancelled. Yes means forex is to be cancelled. No means forex is to be retained.
/// </summary>
public partial record Indicator : IFXCancellation3Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
