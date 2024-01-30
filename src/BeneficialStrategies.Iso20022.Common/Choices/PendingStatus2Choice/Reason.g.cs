﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _QxzOZtp-Ed-ak6NoX_4Aeg_1133108672.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus2Choice;

/// <summary>
/// Reason for the pending status.
/// </summary>
public partial record Reason : IPendingStatus2Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction's processing is pending.
    /// </summary>
    public required IPendingReason4Choice ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
