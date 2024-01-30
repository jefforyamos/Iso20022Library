﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Bloomberg.  ISO2002 ID# _cH1L7TnxEeabspMEjqY5TQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification25Choice;

/// <summary>
/// Identifier of a security assigned by the Bloomberg organisation.
/// </summary>
public partial record Bloomberg : ISecurityIdentification25Choice
{
    public required IsoBloomberg2Identifier Value { get; init; }
}
