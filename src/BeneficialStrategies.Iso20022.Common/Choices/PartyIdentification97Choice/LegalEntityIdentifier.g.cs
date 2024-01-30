﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LegalEntityIdentifier.  ISO2002 ID# _XN4h0SVJEeWI0orciOKunQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification97Choice;

/// <summary>
/// Identification of the party with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 "Financial Services - Legal Entity Identifier (LEI)".
/// </summary>
public partial record LegalEntityIdentifier : IPartyIdentification97Choice
{
    public required IsoLEIIdentifier Value { get; init; }
}
