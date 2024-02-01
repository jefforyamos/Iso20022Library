﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _6BIegZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedStatus19Choice;

/// <summary>
/// Specifies the reason of the unmatched status.
/// </summary>
public partial record Reason : UnmatchedStatus19Choice_
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    public required UnmatchedReason25Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
