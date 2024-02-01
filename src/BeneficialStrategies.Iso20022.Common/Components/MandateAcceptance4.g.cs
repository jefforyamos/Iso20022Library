﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateAcceptance4.  ISO2002 ID# _acF8WR77EeSxevWRRWxNAg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate, which is being accepted.
/// </summary>
public partial record MandateAcceptance4
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    /// <summary>
    /// Provides detailed information on the acceptance result.
    /// </summary>
    public required AcceptanceResult6 AcceptanceResult { get; init; } 
    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    public required OriginalMandate3Choice_ OriginalMandate { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
