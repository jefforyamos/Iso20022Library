﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _y9mPAf7qEeCvPoRGOxRobQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgedAcceptedStatus7Choice;

/// <summary>
/// Specifies the reason of the AcknowledgedAcceptedStatus.
/// </summary>
public partial record Reason : IAcknowledgedAcceptedStatus7Choice
{
    #nullable enable
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    public required IAcknowledgementReason4Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
