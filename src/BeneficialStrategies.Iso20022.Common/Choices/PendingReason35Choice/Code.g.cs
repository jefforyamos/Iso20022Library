﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _cgn4wZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason35Choice;

/// <summary>
/// Standard code to specify the reason why the instruction/event has a pending status.
/// </summary>
public partial record Code : IPendingReason35Choice
{
    public required PendingReason13Code Value { get; init; }
}
