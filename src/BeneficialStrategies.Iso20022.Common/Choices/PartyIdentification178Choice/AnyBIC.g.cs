﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AnyBIC.  ISO2002 ID# _UPdGodgxEeipBO1pkKK6zg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification178Choice;

/// <summary>
/// Unique and unambiguous identifier for an organisation that is allocated by an institution, for example, Dun & Bradstreet Identification.
/// </summary>
public partial record AnyBIC : IPartyIdentification178Choice
{
    public required IsoAnyBICDec2014Identifier Value { get; init; }
}
