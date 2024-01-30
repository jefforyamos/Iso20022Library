﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Status.  ISO2002 ID# _MHhOUCYuEeW_ZNn8gbfY7Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status21Choice;

/// <summary>
/// Status of the transfer cancellation is accepted or sent to next party.
/// </summary>
public partial record Status : IStatus21Choice
{
    #nullable enable
    /// <summary>
    /// Status of the transfer cancellation is accepted or sent to next party.
    /// </summary>
    public required CancellationStatus2Code StatusValue { get; init; } 
    /// <summary>
    /// Reason for the status.
    /// </summary>
    public IsoMax350Text? Reason { get; init; } 
    #nullable disable
}
