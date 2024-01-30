﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _L2HZQOCZEei2UYJ62ws-Fw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedStatus22Choice;

/// <summary>
/// Specifies the reason of the unmatched status.
/// </summary>
public partial record Reason : IUnmatchedStatus22Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    public required IUnmatchedReason30Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
