﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _kov6wZwsEeazcsnODTksnQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason49Choice;

/// <summary>
/// Standard code to specify the reason why the instruction/event has a pending status.
/// </summary>
public partial record Code : IPendingReason49Choice
{
    public required PendingReason14Code Value { get; init; }
}
