﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _EhheFf7ZEeCtrO5qCU90cA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedStatus6Choice;

/// <summary>
/// Specifies the reason of the UnmatchedStatus.
/// </summary>
public partial record Reason : IUnmatchedStatus6Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    public required IUnmatchedReason10Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
