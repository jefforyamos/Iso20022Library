﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedReason.  ISO2002 ID# _86aTc5wtEeazcsnODTksnQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus8Choice;

/// <summary>
/// Reason not specified.
/// </summary>
public partial record NotSpecifiedReason : PendingCancellationStatus8Choice_
{
    public required NoReasonCode Value { get; init; }
}
