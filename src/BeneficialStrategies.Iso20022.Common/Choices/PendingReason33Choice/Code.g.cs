﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _CVo-8UGVEeWqy4niLuXETA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason33Choice;

/// <summary>
/// Standard code to specify the reason why the instruction/event has a pending status.
/// </summary>
public partial record Code : PendingReason33Choice_
{
    public required PendingReason13Code Value { get; init; }
}
