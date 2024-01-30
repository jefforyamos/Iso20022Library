﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _f99MHTi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus69Choice;

/// <summary>
/// Specifies the reason of the pending status.
/// </summary>
public partial record Reason : IPendingStatus69Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction has a pending status.
    /// </summary>
    public required IPendingReason65Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
