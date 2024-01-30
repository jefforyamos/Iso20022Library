﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _oftdyTzpEeWeNtT0s2RbkQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ConsentStatus4Choice;

/// <summary>
/// Reason provided for the status.
/// </summary>
public partial record Reason : IConsentStatus4Choice
{
    #nullable enable
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    public required IConsentOrRejectionReason4Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
