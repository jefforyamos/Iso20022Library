﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NameAndAddress.  ISO2002 ID# _QPrYwtp-Ed-ak6NoX_4Aeg_672026909.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification33Choice;

/// <summary>
/// Name by which a party is known and which is usually used to identify that party.
/// </summary>
public partial record NameAndAddress : IPartyIdentification33Choice
{
    #nullable enable
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax70Text Name { get; init; } 
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    public required PostalAddress2 Address { get; init; } 
    #nullable disable
}
