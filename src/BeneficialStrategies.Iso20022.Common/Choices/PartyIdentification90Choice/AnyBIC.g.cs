﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyBIC.  ISO2002 ID# _TZuskdeeEeSA_uUacqhl1Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification90Choice;

/// <summary>
/// Identification of the party expressed as a BIC.
/// </summary>
public partial record AnyBIC : PartyIdentification90Choice_
{
    public required IsoAnyBICIdentifier Value { get; init; }
}
