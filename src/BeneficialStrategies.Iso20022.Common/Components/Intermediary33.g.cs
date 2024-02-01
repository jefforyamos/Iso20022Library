﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Intermediary33.  ISO2002 ID# _C0fGQSFYEeWgV9SQSyaAog.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party and its role.
/// </summary>
public partial record Intermediary33
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution.
    /// </summary>
    public required PartyIdentification70Choice_ Identification { get; init; } 
    /// <summary>
    /// Identification of the party with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 "Financial Services - Legal Entity Identifier (LEI)".
    /// </summary>
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    public Account20? Account { get; init; } 
    
    #nullable disable
}
