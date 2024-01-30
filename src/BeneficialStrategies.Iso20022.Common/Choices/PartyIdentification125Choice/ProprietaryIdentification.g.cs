﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryIdentification.  ISO2002 ID# _e8twBWpTEeipaMTLlhaKMQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification125Choice;

/// <summary>
/// Unique and unambiguous identifier, as assigned to the party using a proprietary identification scheme.
/// </summary>
public partial record ProprietaryIdentification : IPartyIdentification125Choice
{
    #nullable enable
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IsoMax35Text? SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    #nullable disable
}
