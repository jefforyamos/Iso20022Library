﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DistributionInstructionSD1.  ISO2002 ID# _N_uCcFB8Ee2KGNXAcFL5RA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action distribution instruction details.
/// </summary>
public partial record DistributionInstructionSD1
{
    #nullable enable
    
    /// <summary>
    /// Tax category number assigned on the announcement to provide a breakdown at a category level on the inbound instruction to determine tax treatment as required by issuers, their agents, or tax authorities.
    /// </summary>
    public IReadOnlyCollection<TaxCategory2> TaxCategory { get; init; } = [];
    
    #nullable disable
}
