﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _65Na8ffUEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus25Choice;

/// <summary>
/// Specifies the reason of the cancellation status.
/// </summary>
public partial record Reason : ICancellationStatus25Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction is cancelled.
    /// </summary>
    public required ICancellationReason37Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
