﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _PlnQ2Sd0EeOXAt_43VmZGw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus9Choice;

/// <summary>
/// Reason for the rejected status.
/// </summary>
public partial record Reason : RejectedStatus9Choice_
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction or instruction cancellation has been rejected.
    /// </summary>
    public required RejectedReason5Choice_ ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
