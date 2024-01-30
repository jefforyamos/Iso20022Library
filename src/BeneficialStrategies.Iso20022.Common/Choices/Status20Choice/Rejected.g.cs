﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rejected.  ISO2002 ID# _qrDFoyGaEeWKAaDJcYGKLw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Status20Choice;

/// <summary>
/// Status of the order is rejected.
/// </summary>
public partial record Rejected : IStatus20Choice
{
    #nullable enable
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    public required IRejectedReason16Choice Reason { get; init; } 
    /// <summary>
    /// Additional information about the rejected status reason.
    /// </summary>
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
