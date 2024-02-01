﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _dbWQmSW-EeygjNFjAlVoPA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus67Choice;

/// <summary>
/// Specifies the reason of the pending status.
/// </summary>
public partial record Reason : PendingStatus67Choice_
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction has a pending status.
    /// </summary>
    public required PendingReason63Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
