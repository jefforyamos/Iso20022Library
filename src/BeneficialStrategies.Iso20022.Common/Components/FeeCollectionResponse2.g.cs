﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FeeCollectionResponse2.  ISO2002 ID# _JA1Z0YaBEeuSbct6WWD-Ng.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a fee collection response message.
/// </summary>
public partial record FeeCollectionResponse2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction
    /// </summary>
    public required Environment23 Environment { get; init; } 
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    public Context16? Context { get; init; } 
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    public required Transaction156 Transaction { get; init; } 
    /// <summary>
    /// Outcome of the processing of the authorisation
    /// </summary>
    public required ProcessingResult19 ProcessingResult { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
