﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _D0nCcTqyEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingReason11Choice;

/// <summary>
/// Specifies the reason why the instruction has a pending processing status.
/// </summary>
public partial record Code : IPendingProcessingReason11Choice
{
    public required PendingProcessingReason1Code Value { get; init; }
}
