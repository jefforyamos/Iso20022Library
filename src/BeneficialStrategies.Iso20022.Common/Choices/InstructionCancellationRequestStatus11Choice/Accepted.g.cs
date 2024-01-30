﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Accepted.  ISO2002 ID# _1m6cy4luEeavwKddCbm3hg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionCancellationRequestStatus11Choice;

/// <summary>
/// Provides status information related to a cancellation request accepted for further processing.
/// </summary>
public partial record Accepted : IInstructionCancellationRequestStatus11Choice
{
    #nullable enable
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #nullable disable
}
