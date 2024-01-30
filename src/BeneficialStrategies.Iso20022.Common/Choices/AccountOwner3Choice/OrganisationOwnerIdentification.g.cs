﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OrganisationOwnerIdentification.  ISO2002 ID# _6hURE5TIEemqYPWMBuVawg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AccountOwner3Choice;

/// <summary>
/// Identification of the organisation that legally owns the account.
/// </summary>
public partial record OrganisationOwnerIdentification : IAccountOwner3Choice
{
    #nullable enable
    /// <summary>
    /// Identification of the organisation.
    /// </summary>
    public IPartyIdentification182Choice? Identification { get; init; } 
    /// <summary>
    /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 "Financial Services - Legal Entity Identifier (LEI)".
    /// </summary>
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    #nullable disable
}
