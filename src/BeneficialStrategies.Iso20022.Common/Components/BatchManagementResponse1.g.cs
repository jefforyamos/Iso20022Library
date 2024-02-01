﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BatchManagementResponse1.  ISO2002 ID# _kmF6AFA1EeedyPuM0kK2EQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response to a batch management initiation message.
/// </summary>
public partial record BatchManagementResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the batch management transaction.
    /// </summary>
    public required Environment3 Environment { get; init; } 
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    public Context8? Context { get; init; } 
    /// <summary>
    /// Details about the batch management transaction.
    /// </summary>
    public required Transaction95 Transaction { get; init; } 
    /// <summary>
    /// Outcome of the processing.
    /// </summary>
    public required ProcessingResult3 ProcessingResult { get; init; } 
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    public ProtectedData1[] ProtectedData { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
