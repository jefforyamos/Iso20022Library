﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _6P-zF5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingStatus15Choice;

/// <summary>
/// Specifies the reason of the pending processing status.
/// </summary>
public partial record Reason : IPendingProcessingStatus15Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction has a pending processing status.
    /// </summary>
    public required IPendingProcessingReason14Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
