﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _S2N7WStYEeyhipY4f42fZQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectionOrRepairStatus44Choice;

/// <summary>
/// Specifies the reason of the rejection or repair status.
/// </summary>
public partial record Reason : IRejectionOrRepairStatus44Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejected or repair status.
    /// </summary>
    public required IRejectionAndRepairReason39Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
