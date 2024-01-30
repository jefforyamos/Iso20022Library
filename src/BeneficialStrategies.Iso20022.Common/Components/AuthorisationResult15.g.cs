﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AuthorisationResult15.  ISO2002 ID# _XqFccS5AEeunNvJlR_vCbg.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the authorisation.
/// </summary>
public partial record AuthorisationResult15
{
    #nullable enable
    
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    public GenericIdentification90? AuthorisationEntity { get; init; } 
    /// <summary>
    /// Response to an authorisation request.
    /// </summary>
    public required ResponseType10 ResponseToAuthorisation { get; init; } 
    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    public IsoMin6Max8Text? AuthorisationCode { get; init; } 
    
    #nullable disable
}
