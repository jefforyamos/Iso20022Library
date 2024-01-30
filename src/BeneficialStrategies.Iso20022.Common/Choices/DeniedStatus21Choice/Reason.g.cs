﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _6QE58ZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeniedStatus21Choice;

/// <summary>
/// Specifies the reason of the denied status.
/// </summary>
public partial record Reason : IDeniedStatus21Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the request has a denied status.
    /// </summary>
    public required IDeniedReason21Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
