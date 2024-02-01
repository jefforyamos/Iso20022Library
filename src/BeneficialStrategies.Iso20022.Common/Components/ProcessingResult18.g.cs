﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProcessingResult18.  ISO2002 ID# _zA8IYR1MEey8XKHwKquEQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the verification processing of the transaction.
/// </summary>
public partial record ProcessingResult18
{
    #nullable enable
    
    /// <summary>
    /// The information about entity that provides the response
    /// </summary>
    public ApprovalEntity2? ResponseSource { get; init; } 
    /// <summary>
    /// Result of the processing.
    /// </summary>
    public required ResultData11 ResultData { get; init; } 
    /// <summary>
    /// Value assigned by the entity when the transaction is approved.
    /// </summary>
    public IsoExact6AlphaNumericText? ApprovalCode { get; init; } 
    /// <summary>
    /// Error detail information.
    /// </summary>
    public ErrorDetails2[] ErrorDetail { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    public ResultData7? OriginalResultData { get; init; } 
    /// <summary>
    /// Action required flag.
    /// Default: False: Action Not Required.
    /// True: Action Required.
    /// </summary>
    public IsoYesNoIndicator? ActionRequired { get; init; } 
    /// <summary>
    /// Set of actions to be performed.
    /// </summary>
    public Action13[] Action { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional action to perform.
    /// </summary>
    public AdditionalAction1[] AdditionalAction { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    public AdditionalInformation29[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
