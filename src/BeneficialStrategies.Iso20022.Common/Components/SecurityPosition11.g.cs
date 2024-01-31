﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityPosition11.  ISO2002 ID# _U03_W67yEemG7MmivSuE5g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security and its balance.
/// </summary>
public partial record SecurityPosition11
{
    #nullable enable
    
    /// <summary>
    /// Identification of the security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Amount of securities that are eligible for the vote.
    /// </summary>
    public IReadOnlyCollection<EligiblePosition8> Position { get; init; } = [];
    
    #nullable disable
}
