﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _1ZiGg2XREeOWzsrIp2keDA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingReason4Choice;

/// <summary>
/// Specifies the reason of the MatchedAlleged Status.
/// </summary>
public partial record Reason : IMatchingReason4Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction has been alleged.
    /// </summary>
    public required IAllegementReason1Choice Code { get; init; } 
    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
