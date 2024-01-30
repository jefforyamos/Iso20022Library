﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _6QDEj5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectionStatus24Choice;

/// <summary>
/// Specifies the reason of the rejection status.
/// </summary>
public partial record Reason : IRejectionStatus24Choice
{
    #nullable enable
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    public required IRejectionReason31Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
