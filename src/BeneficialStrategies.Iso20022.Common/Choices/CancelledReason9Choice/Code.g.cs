﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _9U4v80GWEeWqy4niLuXETA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancelledReason9Choice;

/// <summary>
/// Standard code to specify the reason why the instruction is cancelled.
/// </summary>
public partial record Code : ICancelledReason9Choice
{
    public required CancelledStatusReason5Code Value { get; init; }
}
