﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Completed.  ISO2002 ID# _mk9Bs-GKEeWCAvUNsZ5u6g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus71Choice;

/// <summary>
/// Modification request was completed.
/// </summary>
public partial record Completed : IProcessingStatus71Choice
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
