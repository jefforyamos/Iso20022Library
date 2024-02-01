﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _FHgJWe6KEeqc-LCjwLsUVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus61Choice;

/// <summary>
/// Reason for the pending status.
/// </summary>
public partial record Reason : PendingStatus61Choice_
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction's processing is pending.
    /// </summary>
    public required PendingReason57Choice_ ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
