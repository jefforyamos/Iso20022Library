﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedReason.  ISO2002 ID# __KUE-rKiEemux5trsZcCpw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus10Choice;

/// <summary>
/// Reason not specified.
/// </summary>
public partial record NotSpecifiedReason : IPendingCancellationStatus10Choice
{
    public required NoReasonCode Value { get; init; }
}
