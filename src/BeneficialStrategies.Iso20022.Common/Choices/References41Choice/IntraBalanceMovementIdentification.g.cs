﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntraBalanceMovementIdentification.  ISO2002 ID# _QaEOlTnrEeWfSKvvZlhRKg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References41Choice;

/// <summary>
/// Unambiguous identification of the intra balance movement transaction as known by the account owner.
/// </summary>
public partial record IntraBalanceMovementIdentification : IReferences41Choice
{
    public required IsoMax35Text Value { get; init; }
}
