﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _g_hzS7KgEemux5trsZcCpw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus31Choice;

/// <summary>
/// Reason why the meeting instruction cancellation request message or the individual meeting instruction cancellation request is rejected.
/// </summary>
public partial record Reason : IRejectedStatus31Choice
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
