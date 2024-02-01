﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusAndReason29.  ISO2002 ID# _6d7vcZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and reason of a transaction.
/// </summary>
public partial record StatusAndReason29
{
    #nullable enable
    
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    public ProcessingStatus62Choice_? ProcessingStatus { get; init; } 
    /// <summary>
    /// Provides the matching status of an instruction as known by the account servicer based on an allegement. At this time no matching took place on the market (at the CSD/ICSD).
    /// </summary>
    public MatchingStatus32Choice_? InferredMatchingStatus { get; init; } 
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    public MatchingStatus32Choice_? MatchingStatus { get; init; } 
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    public SettlementStatus22Choice_? SettlementStatus { get; init; } 
    
    #nullable disable
}
