﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _kov6nZwsEeazcsnODTksnQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus53Choice;

/// <summary>
/// Reason for the pending status.
/// </summary>
public partial record Reason : IPendingStatus53Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction's processing is pending.
    /// </summary>
    public required IPendingReason49Choice ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
