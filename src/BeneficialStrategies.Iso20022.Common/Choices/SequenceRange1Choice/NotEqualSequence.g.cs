﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotEqualSequence.  ISO2002 ID# _-oyTMYy3EeeGkvZr3jtnCQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SequenceRange1Choice;

/// <summary>
/// Specified sequence to be excluded.
/// </summary>
public partial record NotEqualSequence : ISequenceRange1Choice
{
    public required IsoMax35Text Value { get; init; }
}
