﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ce-6BZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancelledReason10Choice;

/// <summary>
/// Standard code to specify the reason why the instruction is cancelled.
/// </summary>
public partial record Code : ICancelledReason10Choice
{
    public required CancelledStatusReason5Code Value { get; init; }
}
