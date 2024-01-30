﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RejectedStatusReason28.  ISO2002 ID# _2ZcXKrKgEemux5trsZcCpw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a rejected cancellation status.
/// </summary>
public partial record RejectedStatusReason28
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    public required IRejectedReason29Choice ReasonCode { get; init; } 
    /// <summary>
    /// Additional information about the rejection status.
    /// </summary>
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
