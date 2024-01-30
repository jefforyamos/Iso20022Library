﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Accepted.  ISO2002 ID# _V5aGixn0EeyroI8qKgB7Mg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus13Choice;

/// <summary>
/// Provides status information related to a cancellation request accepted for further processing.
/// </summary>
public partial record Accepted : IInstructionCancellationRequestStatus13Choice
{
    #nullable enable
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #nullable disable
}
