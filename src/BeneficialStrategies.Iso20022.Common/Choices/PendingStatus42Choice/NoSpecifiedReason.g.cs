﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _B6kMgUGVEeWqy4niLuXETA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus42Choice;

/// <summary>
/// Reason not specified.
/// </summary>
public partial record NoSpecifiedReason : IPendingStatus42Choice
{
    public required NoReasonCode Value { get; init; }
}
