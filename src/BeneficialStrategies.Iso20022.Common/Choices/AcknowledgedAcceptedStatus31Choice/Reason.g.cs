﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _6QETNZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgedAcceptedStatus31Choice;

/// <summary>
/// Specifies the reason of the acknowledged accepted status.
/// </summary>
public partial record Reason : AcknowledgedAcceptedStatus31Choice_
{
    #nullable enable
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    public required AcknowledgementReason22Choice_ Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
