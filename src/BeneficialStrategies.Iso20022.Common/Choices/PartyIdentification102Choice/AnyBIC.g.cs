﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyBIC.  ISO2002 ID# _JgLAA4bCEeWguotXa4lFgg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification102Choice;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
public partial record AnyBIC : IPartyIdentification102Choice
{
    public required IsoAnyBICIdentifier Value { get; init; }
}
