﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rejected.  ISO2002 ID# _Hri4Mx6rEeODgY9qxg6TFA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status14Choice;

/// <summary>
/// Status of the order is rejected.
/// </summary>
public partial record Rejected : IStatus14Choice
{
    #nullable enable
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    public required IRejectedReason4Choice Reason { get; init; } 
    /// <summary>
    /// Additional information about the rejected status reason.
    /// </summary>
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
