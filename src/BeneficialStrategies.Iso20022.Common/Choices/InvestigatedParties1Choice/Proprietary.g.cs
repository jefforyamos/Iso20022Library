﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _xz3ZQTwTEeGKuZXNQxGH3g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InvestigatedParties1Choice;

/// <summary>
/// Specifies the investigated parties as a proprietary code.
/// </summary>
public partial record Proprietary : IInvestigatedParties1Choice
{
    public required IsoMax35Text Value { get; init; }
}
