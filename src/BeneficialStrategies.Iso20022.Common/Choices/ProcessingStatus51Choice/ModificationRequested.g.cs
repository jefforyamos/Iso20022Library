﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ModificationRequested.  ISO2002 ID# _jWWVoTnvEeWfSKvvZlhRKg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus51Choice;

/// <summary>
/// Modification request from your counterparty for this transaction is pending waiting for your cancellation request or your consent.
/// </summary>
public partial record ModificationRequested : IProcessingStatus51Choice
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
