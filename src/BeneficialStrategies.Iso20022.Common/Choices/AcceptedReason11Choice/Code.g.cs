﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _cgn4IZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedReason11Choice;

/// <summary>
/// Standard code to specify additional information about the processed instruction.
/// </summary>
public partial record Code : IAcceptedReason11Choice
{
    public required AcknowledgementReason7Code Value { get; init; }
}
