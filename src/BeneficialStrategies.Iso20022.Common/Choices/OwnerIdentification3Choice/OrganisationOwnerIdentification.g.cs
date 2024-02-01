﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OrganisationOwnerIdentification.  ISO2002 ID# _CKjZs5TREemC09f0MxYkRg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OwnerIdentification3Choice;

/// <summary>
/// Identification of an organisation.
/// </summary>
public partial record OrganisationOwnerIdentification : OwnerIdentification3Choice_
{
    #nullable enable
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    public required PartyIdentification125Choice_ Party { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    #nullable disable
}
