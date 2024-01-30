﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CancellationCompleted.  ISO2002 ID# _A4HJNdokEeC60axPepSq7g_171294284.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancellationProcessingStatus6Choice;

/// <summary>
/// Cancellation is completed.
/// </summary>
public partial record CancellationCompleted : ICancellationProcessingStatus6Choice
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the reason related to a status.
    /// </summary>
    public GenericIdentification20? Reason { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
