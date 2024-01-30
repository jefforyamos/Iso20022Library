﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProcessingStatus.  ISO2002 ID# _sSu2s16uEeSyc4g_pm5hbw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus6Choice;

/// <summary>
/// Status advising on the processing of the instruction.
/// </summary>
public partial record ProcessingStatus : IInstructionStatus6Choice
{
    #nullable enable
    /// <summary>
    /// Status on the processing of the instructions.
    /// </summary>
    public required Status7Code Status { get; init; } 
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #nullable disable
}
