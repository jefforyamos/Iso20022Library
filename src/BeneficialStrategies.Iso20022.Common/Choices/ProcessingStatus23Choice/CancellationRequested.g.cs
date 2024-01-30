﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CancellationRequested.  ISO2002 ID# _tTjymf7sEeCvPoRGOxRobQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus23Choice;

/// <summary>
/// Cancellation request from your counterparty for this transaction is pending waiting for your cancellation request.
/// </summary>
public partial record CancellationRequested : IProcessingStatus23Choice
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
