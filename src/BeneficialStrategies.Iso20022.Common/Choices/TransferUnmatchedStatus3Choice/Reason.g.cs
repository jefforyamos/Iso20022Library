﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _eLXpxSY4EeW_ZNn8gbfY7Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TransferUnmatchedStatus3Choice;

/// <summary>
/// Reason for the unmatched status.
/// </summary>
public partial record Reason : ITransferUnmatchedStatus3Choice
{
    public required TransferUnmatchedReason2Code Value { get; init; }
}
