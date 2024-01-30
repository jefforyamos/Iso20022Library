﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _sHBO-Tq1EeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus13Choice;

/// <summary>
/// Specifies the reason of the pending processing status.
/// </summary>
public partial record Reason : IPendingProcessingStatus13Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction has a pending processing status.
    /// </summary>
    public required IPendingProcessingReason12Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
