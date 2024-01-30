﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _Vl2wOZNSEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ConsentStatus5Choice;

/// <summary>
/// Reason provided for the status.
/// </summary>
public partial record Reason : IConsentStatus5Choice
{
    #nullable enable
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    public required IConsentOrRejectionReason5Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
