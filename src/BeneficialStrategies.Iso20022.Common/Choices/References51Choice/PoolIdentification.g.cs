﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PoolIdentification.  ISO2002 ID# _5Qz095NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References51Choice;

/// <summary>
/// Collective reference identifying a set of messages.
/// </summary>
public partial record PoolIdentification : IReferences51Choice
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
