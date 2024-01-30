﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ClearingBatchData2.  ISO2002 ID# _oY5L8ZMxEeuleeHpFMMhmQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Clearing data at batch level. Allows clearing in different currencies.
/// </summary>
public partial record ClearingBatchData2
{
    #nullable enable
    
    /// <summary>
    /// Type of clearing method used.
    /// </summary>
    public required ClearingMethod2Code ClearingMethod { get; init; } 
    /// <summary>
    /// Other type of clearing method.
    /// </summary>
    public IsoMax35Text? OtherClearingMethod { get; init; } 
    /// <summary>
    /// Level of priority of clearing.
    /// </summary>
    public IsoMax35Text? ClearingPriority { get; init; } 
    /// <summary>
    /// Date of clearing.
    /// </summary>
    public IsoISODate? ClearingDate { get; init; } 
    /// <summary>
    /// Clearing totals of the batch file.
    /// </summary>
    public ClearingTotals2? ClearingTotals { get; init; } 
    /// <summary>
    /// Interchange fee.
    /// </summary>
    public Amount17? InterchangeFee { get; init; } 
    /// <summary>
    /// Fee of the agent.
    /// </summary>
    public Amount17? AgentFee { get; init; } 
    
    #nullable disable
}
