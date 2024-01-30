﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NameAndAddress.  ISO2002 ID# _JVFG-SjIEeKnA5P_jl2DUw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification73Choice;

/// <summary>
/// Identification of the party expressed as name and an optional address and an optional alternative identifier.
/// </summary>
public partial record NameAndAddress : IPartyIdentification73Choice
{
    #nullable enable
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax350Text Name { get; init; } 
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    public PostalAddress1? Address { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    // public IReadOnlyCollection<IsoMax35Text> AlternativeIdentifier { get; init; }
    #nullable disable
}
