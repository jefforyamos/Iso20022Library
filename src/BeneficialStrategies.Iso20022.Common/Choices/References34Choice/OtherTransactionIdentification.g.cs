﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherTransactionIdentification.  ISO2002 ID# _jvNYxO5NEeCisYr99QEiWA_-1943122229.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References34Choice;

/// <summary>
/// Identification of a transaction that cannot be identified using a standard reference element present in the message.
/// </summary>
public partial record OtherTransactionIdentification : IReferences34Choice
{
    public required IsoMax35Text Value { get; init; }
}
