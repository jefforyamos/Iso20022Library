﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntraPositionMovementIdentification.  ISO2002 ID# _IIcauTqoEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References44Choice;

/// <summary>
/// Reference to the intra-position movement transaction requested to be cancelled as known by the account owner (or instructing party acting on its behalf).
/// </summary>
public partial record IntraPositionMovementIdentification : References44Choice_
{
    public required IsoMax35Text Value { get; init; }
}
