﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StandingInstruction.  ISO2002 ID# _bHlEi-6BEeqc-LCjwLsUVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus40Choice;

/// <summary>
/// Standing instruction has been applied.
/// </summary>
public partial record StandingInstruction : IInstructionProcessingStatus40Choice
{
    #nullable enable
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #nullable disable
}
