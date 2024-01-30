﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityPosition6.  ISO2002 ID# _QTaCNdp-Ed-ak6NoX_4Aeg_-582916783.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the securities for which the meeting is organised.
/// </summary>
public partial record SecurityPosition6
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    public required SecurityIdentification11 Identification { get; init; } 
    /// <summary>
    /// Amount of securities that are eligible for the vote.
    /// </summary>
    // public IReadOnlyCollection<EligiblePosition3> Position { get; init; }
    
    #nullable disable
}
