﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _inS8ICYwEeW_ZNn8gbfY7Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancellationCompleteReason1Choice;

/// <summary>
/// Cancelled complete reason expressed as a code.
/// </summary>
public partial record Code : ICancellationCompleteReason1Choice
{
    public required CancelledStatusReason1Code Value { get; init; }
}
