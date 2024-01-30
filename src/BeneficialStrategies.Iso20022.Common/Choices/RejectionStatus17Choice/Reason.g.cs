﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _rRXEOTqzEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionStatus17Choice;

/// <summary>
/// Specifies the reason of the rejection status.
/// </summary>
public partial record Reason : IRejectionStatus17Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejected or repair status.
    /// </summary>
    public required IRejectionReason23Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
