﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _hQwiCTnvEeWfSKvvZlhRKg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgedAcceptedStatus21Choice;

/// <summary>
/// Specifies the reason of the acknowledged accepted status.
/// </summary>
public partial record Reason : IAcknowledgedAcceptedStatus21Choice
{
    #nullable enable
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    public required IAcknowledgementReason12Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
