﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StandingInstruction.  ISO2002 ID# _U3YuDeJxEd-Q6MzBzY5WkA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus7Choice;

/// <summary>
/// Standing instruction has been applied.
/// </summary>
public partial record StandingInstruction : InstructionProcessingStatus7Choice_
{
    #nullable enable
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #nullable disable
}
