﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Indicator.  ISO2002 ID# _5m6A5ZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.BeneficialOwnership5Choice;

/// <summary>
/// Specifies whether there is change of beneficial ownership.
/// </summary>
public partial record Indicator : IBeneficialOwnership5Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
