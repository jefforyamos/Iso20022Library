﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMKeyDownloadRequest2.  ISO2002 ID# _no7dga45EeWRfYPBaeOY8w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of a key download from an ATM.
/// </summary>
public partial record ATMKeyDownloadRequest2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the key download.
    /// </summary>
    public required ATMEnvironment15 Environment { get; init; } 
    /// <summary>
    /// Result of a maintenance command performed by the ATM.
    /// </summary>
    public ATMCommand2[] CommandResult { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Security command in progress inside which the key download is requested.
    /// </summary>
    public ATMCommand3? CommandContext { get; init; } 
    /// <summary>
    /// Context of the ATM for the key download.
    /// </summary>
    public required ATMSecurityContext2 ATMSecurityContext { get; init; } 
    /// <summary>
    /// Security parameters of the ATM for the initiated key download.
    /// </summary>
    public required SecurityParameters4 ATMSecurityParameters { get; init; } 
    /// <summary>
    /// Random value from the host provided during a previous exchange.
    /// </summary>
    public IsoMax140Binary? HostChallenge { get; init; } 
    
    #nullable disable
}
