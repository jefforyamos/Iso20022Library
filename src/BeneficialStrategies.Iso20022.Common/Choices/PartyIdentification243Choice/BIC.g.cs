﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BIC.  ISO2002 ID# _vh2XwwauEe2phaVG0lYKTw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification243Choice;

/// <summary>
/// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun & Bradstreet Identification.
/// </summary>
public partial record BIC : IPartyIdentification243Choice
{
    public required IsoAnyBICDec2014Identifier Value { get; init; }
}
