﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LEI.  ISO2002 ID# _ctD2Y_fSEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification151Choice;

/// <summary>
/// Legal entity identification of the party.
/// </summary>
public partial record LEI : IPartyIdentification151Choice
{
    public required IsoLEIIdentifier Value { get; init; }
}
