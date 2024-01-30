﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _KqoEeRn1EeyroI8qKgB7Mg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus43Choice;

/// <summary>
/// Reason for the rejected status.
/// </summary>
public partial record Reason : IRejectedStatus43Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction or instruction cancellation has been rejected.
    /// </summary>
    public required IRejectedReason43Choice ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
