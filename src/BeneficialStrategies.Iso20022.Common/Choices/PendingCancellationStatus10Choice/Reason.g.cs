﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# __KUE-7KiEemux5trsZcCpw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus10Choice;

/// <summary>
/// Reason why the meeting instruction cancellation request message or the individual meeting instruction cancellation request is pending.
/// </summary>
public partial record Reason : PendingCancellationStatus10Choice_
{
    #nullable enable
    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    public required PendingCancellationReason7Choice_ ReasonCode { get; init; } 
    /// <summary>
    /// Additional information about the pending status.
    /// </summary>
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
