﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _P3gGFSY5EeW_ZNn8gbfY7Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancelledStatus13Choice;

/// <summary>
/// Reason for the cancelled status.
/// </summary>
public partial record Reason : ICancelledStatus13Choice
{
    public required CancelledStatusReason3Code Value { get; init; }
}
