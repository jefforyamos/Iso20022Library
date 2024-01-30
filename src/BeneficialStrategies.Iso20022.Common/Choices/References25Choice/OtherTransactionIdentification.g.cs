﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherTransactionIdentification.  ISO2002 ID# _XGUCbf7uEeCvPoRGOxRobQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References25Choice;

/// <summary>
/// Identification of a transaction that cannot be identified using a standard reference element present in the message.
/// </summary>
public partial record OtherTransactionIdentification : IReferences25Choice
{
    public required IsoMax35Text Value { get; init; }
}
