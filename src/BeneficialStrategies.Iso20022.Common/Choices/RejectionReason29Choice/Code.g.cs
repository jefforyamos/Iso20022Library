﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _6HWbRZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason29Choice;

/// <summary>
/// Specifies the reason why the instruction/request has a rejection status using a code.
/// </summary>
public partial record Code : IRejectionReason29Choice
{
    public required RejectionReason40Code Value { get; init; }
}
