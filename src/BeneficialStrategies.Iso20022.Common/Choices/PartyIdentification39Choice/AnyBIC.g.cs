﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyBIC.  ISO2002 ID# _1Y_BIfL9Ed-3lpUMQaXLjQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification39Choice;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
public partial record AnyBIC : IPartyIdentification39Choice
{
    public required IsoAnyBICIdentifier Value { get; init; }
}
