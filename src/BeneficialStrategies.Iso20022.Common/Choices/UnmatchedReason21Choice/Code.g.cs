﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _JNzfETqOEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedReason21Choice;

/// <summary>
/// Specifies the reason why the instruction has an unmatched status.
/// </summary>
public partial record Code : IUnmatchedReason21Choice
{
    public required UnmatchedReason11Code Value { get; init; }
}
