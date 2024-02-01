﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AuthorisationResult9.  ISO2002 ID# _TJtuMYp8EeS3NqNpgnMh2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the withdrawal authorisation.
/// </summary>
public partial record AuthorisationResult9
{
    #nullable enable
    
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    public PartyType13Code? AuthorisationEntity { get; init; } 
    /// <summary>
    /// Result of the authorisation.
    /// </summary>
    public required ResponseType3 AuthorisationResponse { get; init; } 
    /// <summary>
    /// Trace of response by the entities in the path from the issuer to the ATM.
    /// </summary>
    public ResponseType4[] ResponseTrace { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    public IsoMin6Max8Text? AuthorisationCode { get; init; } 
    /// <summary>
    /// Sequence of actions to be performed by the ATM to complete the transaction.
    /// </summary>
    public Action5[] Action { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
