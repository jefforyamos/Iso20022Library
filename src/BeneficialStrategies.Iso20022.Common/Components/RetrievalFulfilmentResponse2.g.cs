﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RetrievalFulfilmentResponse2.  ISO2002 ID# _yeyOwYHWEeu7P-fjMhpKOg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to a RetrievalFulfilmentInitiation message.
/// </summary>
public partial record RetrievalFulfilmentResponse2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required Environment21 Environment { get; init; } 
    /// <summary>
    /// Context of the transaction.
    /// </summary>
    public required Context15 Context { get; init; } 
    /// <summary>
    /// Original transaction for which a retrieval is requested.
    /// </summary>
    public Transaction136? Transaction { get; init; } 
    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    public required ProcessingResult19 ProcessingResult { get; init; } 
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    public ProtectedData1? ProtectedData { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
