﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for EqualSequence.  ISO2002 ID# _8FIqsYy3EeeGkvZr3jtnCQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SequenceRange1Choice;

/// <summary>
/// Specified sequence to match.
/// </summary>
public partial record EqualSequence : SequenceRange1Choice_
{
    public required IsoMax35Text Value { get; init; }
}
