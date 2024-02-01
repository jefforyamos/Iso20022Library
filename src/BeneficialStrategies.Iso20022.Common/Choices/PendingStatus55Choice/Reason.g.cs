﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _Tfp1KrKdEemux5trsZcCpw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus55Choice;

/// <summary>
/// Reason why the meeting instruction message or the individual meeting instruction is pending.
/// </summary>
public partial record Reason : PendingStatus55Choice_
{
    #nullable enable
    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    public required PendingReason51Choice_ ReasonCode { get; init; } 
    /// <summary>
    /// Additional information about the pending status.
    /// </summary>
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
