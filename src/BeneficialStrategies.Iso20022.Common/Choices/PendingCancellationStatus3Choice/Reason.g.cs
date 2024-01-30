﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _lFW2nQFnEeG2HcWTGfYeDQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus3Choice;

/// <summary>
/// Reason for the pending cancellation status.
/// </summary>
public partial record Reason : IPendingCancellationStatus3Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the cancellation request is pending.
    /// </summary>
    public required IPendingCancellationReason1Choice ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
