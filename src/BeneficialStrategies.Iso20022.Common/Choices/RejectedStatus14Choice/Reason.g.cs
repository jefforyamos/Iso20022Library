﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _1_0SSVhnEeSsH9MSoogb7Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus14Choice;

/// <summary>
/// Reason for the rejected status.
/// </summary>
public partial record Reason : IRejectedStatus14Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction or instruction cancellation has been rejected.
    /// </summary>
    public required IRejectedReason10Choice ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
