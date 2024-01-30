﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Status.  ISO2002 ID# _ym2jwZM6EemKz5EOjv82iQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status31Choice;

/// <summary>
/// Status of the transfer cancellation is accepted or sent to next party.
/// </summary>
public partial record Status : IStatus31Choice
{
    #nullable enable
    /// <summary>
    /// Status of the transfer cancellation is accepted or sent to next party.
    /// </summary>
    public required CancellationStatus5Code StatusValue { get; init; } 
    /// <summary>
    /// Reason for the status.
    /// </summary>
    public IsoMax350Text? Reason { get; init; } 
    #nullable disable
}
