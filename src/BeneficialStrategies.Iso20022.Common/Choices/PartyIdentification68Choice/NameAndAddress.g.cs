﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NameAndAddress.  ISO2002 ID# _AUMj1dokEeC60axPepSq7g_-2137965810.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification68Choice;

/// <summary>
/// Identification of a party with its name and address in free text.
/// </summary>
public partial record NameAndAddress : IPartyIdentification68Choice
{
    #nullable enable
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax350Text Name { get; init; } 
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    public PostalAddress8? Address { get; init; } 
    #nullable disable
}
