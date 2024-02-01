﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProcessingResult1.  ISO2002 ID# _Sxhy0EXaEeegp_DADCe7HQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the processing of the transaction.
/// </summary>
public partial record ProcessingResult1
{
    #nullable enable
    
    /// <summary>
    /// Data pertaining to the approval of the transaction.
    /// </summary>
    public ApprovalData1? ApprovalData { get; init; } 
    /// <summary>
    /// Result of the processing.
    /// </summary>
    public ResultData1? ResultData { get; init; } 
    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    public ResultData1? OriginalResultData { get; init; } 
    /// <summary>
    /// Action required flag.
    /// Default: False: Action Not Required.
    /// True: Action Required.
    /// </summary>
    public IsoYesNoIndicator? ActionRequired { get; init; } 
    /// <summary>
    /// Set of actions to be performed.
    /// ISO 8583 bit 39
    /// </summary>
    public Action9[] Action { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional action to perform.
    /// </summary>
    public AdditionalAction1[] AdditionalAction { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    public AdditionalInformation20[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
