﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyBIC.  ISO2002 ID# _3YMtY_1REeixXcHVEYIW2g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification152Choice;

/// <summary>
/// Identification of the party expressed as a BIC.
/// </summary>
public partial record AnyBIC : IPartyIdentification152Choice
{
    public required IsoAnyBICDec2014Identifier Value { get; init; }
}
