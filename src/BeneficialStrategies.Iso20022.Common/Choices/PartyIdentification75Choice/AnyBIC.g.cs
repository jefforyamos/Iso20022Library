﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyBIC.  ISO2002 ID# _HitG0UiQEeOdL6nMHefDgg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification75Choice;

/// <summary>
/// Identification of the party expressed as a BIC.
/// </summary>
public partial record AnyBIC : PartyIdentification75Choice_
{
    public required IsoAnyBICIdentifier Value { get; init; }
}
