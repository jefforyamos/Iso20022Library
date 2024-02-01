﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IssuerAgent2.  ISO2002 ID# _ciBrAVthEeSwKe7KuKvXhg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the role of the issuer agent.
/// </summary>
public partial record IssuerAgent2
{
    #nullable enable
    
    /// <summary>
    /// Identifies issuer agent.
    /// </summary>
    public required PartyIdentification40Choice_ Identification { get; init; } 
    /// <summary>
    /// Specifies the role of the issuer agent.
    /// </summary>
    public AgentRole1Code? Role { get; init; } 
    
    #nullable disable
}
