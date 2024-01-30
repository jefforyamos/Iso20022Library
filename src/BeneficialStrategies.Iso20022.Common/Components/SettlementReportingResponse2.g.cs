﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementReportingResponse2.  ISO2002 ID# _KfS0QYwFEeugeuahCxXQ-Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the  settlement response message.
/// </summary>
public partial record SettlementReportingResponse2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required Environment27 Environment { get; init; } 
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    public Context17? Context { get; init; } 
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    public required Transaction139 Transaction { get; init; } 
    /// <summary>
    /// Processing results of the settlement service.
    /// </summary>
    public required ProcessingResult13 ProcessingResult { get; init; } 
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
