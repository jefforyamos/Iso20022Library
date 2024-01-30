﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NameAndAddress.  ISO2002 ID# _8GnIH_fREeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification147Choice;

/// <summary>
/// Name by which a party is known and which is usually used to identify that party.
/// </summary>
public partial record NameAndAddress : IPartyIdentification147Choice
{
    #nullable enable
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoRestrictedFINXMax140Text Name { get; init; } 
    #nullable disable
}
