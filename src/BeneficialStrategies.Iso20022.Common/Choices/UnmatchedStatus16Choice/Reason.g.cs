﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _IMDHJTqOEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedStatus16Choice;

/// <summary>
/// Specifies the reason of the unmatched status.
/// </summary>
public partial record Reason : UnmatchedStatus16Choice_
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// </summary>
    public required UnmatchedReason21Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
