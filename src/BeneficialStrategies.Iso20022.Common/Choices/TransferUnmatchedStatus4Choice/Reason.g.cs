﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _k75sI5M5EemKz5EOjv82iQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TransferUnmatchedStatus4Choice;

/// <summary>
/// Reason for the unmatched status.
/// </summary>
public partial record Reason : ITransferUnmatchedStatus4Choice
{
    public required TransferUnmatchedReason3Code Value { get; init; }
}
