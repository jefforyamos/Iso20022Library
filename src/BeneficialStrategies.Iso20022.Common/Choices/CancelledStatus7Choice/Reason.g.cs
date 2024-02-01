﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _cqViq1hlEeSsH9MSoogb7Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancelledStatus7Choice;

/// <summary>
/// Reason for the cancelled status.
/// </summary>
public partial record Reason : CancelledStatus7Choice_
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction or instruction cancellation has been cancelled.
    /// </summary>
    public required CancelledReason5Choice_ ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
