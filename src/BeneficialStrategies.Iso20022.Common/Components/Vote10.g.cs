﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Vote10.  ISO2002 ID# _Y98Lt64cEemG7MmivSuE5g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vote expressed for one resolution.
/// </summary>
public partial record Vote10
{
    #nullable enable
    
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    public required IsoMax35Text IssuerLabel { get; init; } 
    /// <summary>
    /// Vote instructed.
    /// </summary>
    public required IVoteInstructionType1Choice VoteOption { get; init; } 
    
    #nullable disable
}
