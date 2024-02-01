﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NetworkManagementInitiation1.  ISO2002 ID# _hhfqsVWSEeeiG_nL4vgKnQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to network management services.
/// </summary>
public partial record NetworkManagementInitiation1
{
    #nullable enable
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    public Context8? Context { get; init; } 
    /// <summary>
    /// Details of an exchange or interaction between parties to perform a specific function.
    /// </summary>
    public required Transaction99 Transaction { get; init; } 
    /// <summary>
    /// Outcome of the processing of the authorisation
    /// </summary>
    public ProcessingResult1? ProcessingResult { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
