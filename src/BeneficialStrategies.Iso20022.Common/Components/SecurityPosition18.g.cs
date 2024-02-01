﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityPosition18.  ISO2002 ID# _nyeCmzRTEe2id-MjcNoBdw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a security and its balance.
/// </summary>
public partial record SecurityPosition18
{
    #nullable enable
    
    /// <summary>
    /// Identification of the security, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Amount of securities that are eligible for the vote.
    /// </summary>
    public EligiblePosition15[] Position { get; init; } = [];
    
    #nullable disable
}
