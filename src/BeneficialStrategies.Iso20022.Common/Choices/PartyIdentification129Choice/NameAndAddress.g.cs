﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NameAndAddress.  ISO2002 ID# _CaOE5bXLEeiTob_PrFFUxA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification129Choice;

/// <summary>
/// Name and address of a party.
/// </summary>
public partial record NameAndAddress : IPartyIdentification129Choice
{
    #nullable enable
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax350Text Name { get; init; } 
    /// <summary>
    /// Postal address of the party.
    /// </summary>
    public PostalAddress1? Address { get; init; } 
    #nullable disable
}
