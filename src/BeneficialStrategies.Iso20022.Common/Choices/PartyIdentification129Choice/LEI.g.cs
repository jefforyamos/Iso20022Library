﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LEI.  ISO2002 ID# _TRuNgLXLEeiTob_PrFFUxA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification129Choice;

/// <summary>
/// Legal entity identification of the party.
/// </summary>
public partial record LEI : IPartyIdentification129Choice
{
    public required IsoLEIIdentifier Value { get; init; }
}
