﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProcessingResult19.  ISO2002 ID# _lsmvER1NEey8XKHwKquEQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the processing of the transaction.
/// </summary>
public partial record ProcessingResult19
{
    #nullable enable
    
    /// <summary>
    /// Information about the entity that provides the response.
    /// </summary>
    public ApprovalEntity2? ResponseSource { get; init; } 
    /// <summary>
    /// Result of the processing.
    /// </summary>
    public required ResultData10 ResultData { get; init; } 
    /// <summary>
    /// Error detail information
    /// </summary>
    public ErrorDetails2? ErrorDetail { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    public ResultData7? OriginalResultData { get; init; } 
    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    public AdditionalInformation30? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
