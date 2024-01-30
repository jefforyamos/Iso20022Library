﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityPosition10.  ISO2002 ID# _T2Pz4a7yEemG7MmivSuE5g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security and its balance.
/// </summary>
public partial record SecurityPosition10
{
    #nullable enable
    
    /// <summary>
    /// Identification of the security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Amount of securities that are eligible for the vote.
    /// </summary>
    // public IReadOnlyCollection<EligiblePosition7> Position { get; init; }
    
    #nullable disable
}
