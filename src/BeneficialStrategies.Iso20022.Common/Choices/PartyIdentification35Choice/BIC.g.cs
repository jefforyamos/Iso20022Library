﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BIC.  ISO2002 ID# _QPYd4tp-Ed-ak6NoX_4Aeg_-1637770801.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification35Choice;

/// <summary>
/// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun & Bradstreet Identification.
/// </summary>
public partial record BIC : IPartyIdentification35Choice
{
    public required IsoAnyBICIdentifier Value { get; init; }
}
