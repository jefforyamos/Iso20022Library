﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _6BFbu5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingReason13Choice;

/// <summary>
/// Specifies the reason why the instruction has a pending processing status.
/// </summary>
public partial record Code : IPendingProcessingReason13Choice
{
    public required PendingProcessingReason1Code Value { get; init; }
}
