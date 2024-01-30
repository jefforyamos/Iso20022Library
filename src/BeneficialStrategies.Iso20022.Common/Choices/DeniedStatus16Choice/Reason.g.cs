﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _t0nF2Ts8EeWRTLSN0i0tng.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DeniedStatus16Choice;

/// <summary>
/// Specifies the reason of the denied status.
/// </summary>
public partial record Reason : IDeniedStatus16Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the request has a denied status.
    /// </summary>
    public required IDeniedReason16Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
