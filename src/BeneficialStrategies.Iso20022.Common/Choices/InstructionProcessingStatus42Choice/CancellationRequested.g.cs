﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CancellationRequested.  ISO2002 ID# _7X_7FQpJEeup4r-PFG2T5Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus42Choice;

/// <summary>
/// Cancellation request from your counterparty for this transaction is pending waiting for your cancellation request.
/// </summary>
public partial record CancellationRequested : IInstructionProcessingStatus42Choice
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the reason related to a status.
    /// </summary>
    public GenericIdentification30? Reason { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
