﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProcessingResult13.  ISO2002 ID# _jFmMUcsWEeuNe7RtB4qFHw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the processing of the batch.
/// </summary>
public partial record ProcessingResult13
{
    #nullable enable
    
    /// <summary>
    /// The information about entity that provides the response
    /// </summary>
    public ApprovalEntity2? ResponseSource { get; init; } 
    /// <summary>
    /// Result information related to the processing of the transaction.
    /// </summary>
    public required ResultData8 ResultData { get; init; } 
    /// <summary>
    /// Value assigned by the entity when the transaction is approved.
    /// </summary>
    public IsoExact6AlphaNumericText? ApprovalCode { get; init; } 
    /// <summary>
    /// Error detail information.
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
    public AdditionalInformation29? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
