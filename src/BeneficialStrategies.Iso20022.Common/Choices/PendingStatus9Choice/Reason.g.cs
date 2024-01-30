﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _Bsv4W_40EeClUvPNHKL9Zw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus9Choice;

/// <summary>
/// Specifies the reason of the PendingStatus.
/// </summary>
public partial record Reason : IPendingStatus9Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction has a pending status.
    /// </summary>
    public required IPendingReason13Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
