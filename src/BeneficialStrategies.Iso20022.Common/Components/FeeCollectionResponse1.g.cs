﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FeeCollectionResponse1.  ISO2002 ID# _6pSKMVchEeeFltjJxERUxw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a fee collection response message.
/// </summary>
public partial record FeeCollectionResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction
    /// </summary>
    public required Environment5 Environment { get; init; } 
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    public Context9? Context { get; init; } 
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    public required Transaction103 Transaction { get; init; } 
    /// <summary>
    /// Outcome of the processing of the authorisation
    /// </summary>
    public required ProcessingResult4 ProcessingResult { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
