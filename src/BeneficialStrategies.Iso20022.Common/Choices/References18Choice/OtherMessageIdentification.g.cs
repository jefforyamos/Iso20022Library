﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherMessageIdentification.  ISO2002 ID# _9Eijmz9mEeCuVfEpWlZb5g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References18Choice;

/// <summary>
/// Unambiguous identification of the message to be cancelled.
/// </summary>
public partial record OtherMessageIdentification : IReferences18Choice
{
    public required IsoMax35Text Value { get; init; }
}
