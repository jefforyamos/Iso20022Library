﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _cgnRxZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancelledReason11Choice;

/// <summary>
/// Standard code to specify the reason why the instruction is cancelled.
/// </summary>
public partial record Code : ICancelledReason11Choice
{
    public required CancelledStatusReason6Code Value { get; init; }
}
