﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CancellationRequested.  ISO2002 ID# _UV8Dhtp-Ed-ak6NoX_4Aeg_952313343.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus3Choice;

/// <summary>
/// Cancellation request from your counterparty for this transaction is pending waiting for your cancellation request or your consent.
/// </summary>
public partial record CancellationRequested : IProcessingStatus3Choice
{
    #nullable enable
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #nullable disable
}
