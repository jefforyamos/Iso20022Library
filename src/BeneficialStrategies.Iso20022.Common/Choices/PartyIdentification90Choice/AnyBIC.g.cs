﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyBIC.  ISO2002 ID# _TZuskdeeEeSA_uUacqhl1Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification90Choice;

/// <summary>
/// Identification of the party expressed as a BIC.
/// </summary>
public partial record AnyBIC : IPartyIdentification90Choice
{
    public required IsoAnyBICIdentifier Value { get; init; }
}
