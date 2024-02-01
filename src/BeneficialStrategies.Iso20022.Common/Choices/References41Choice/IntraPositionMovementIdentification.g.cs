﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntraPositionMovementIdentification.  ISO2002 ID# _QaEOjTnrEeWfSKvvZlhRKg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References41Choice;

/// <summary>
/// Unambiguous identification of the intra-position movement transaction as known by the account owner (or instructing party acting on its behalf).
/// </summary>
public partial record IntraPositionMovementIdentification : References41Choice_
{
    public required IsoMax35Text Value { get; init; }
}
