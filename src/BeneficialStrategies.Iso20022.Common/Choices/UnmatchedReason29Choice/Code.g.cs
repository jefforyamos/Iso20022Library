﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _8QddeZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedReason29Choice;

/// <summary>
/// Specifies the reason why the instruction has an unmatched status.
/// </summary>
public partial record Code : IUnmatchedReason29Choice
{
    public required UnmatchedReason14Code Value { get; init; }
}
