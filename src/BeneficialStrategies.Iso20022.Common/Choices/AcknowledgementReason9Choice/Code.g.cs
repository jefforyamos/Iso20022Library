﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _0jOiAQlIEeGATtfOBToyew_-1213196427.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgementReason9Choice;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
public partial record Code : IAcknowledgementReason9Choice
{
    public required AcknowledgementReason6Code Value { get; init; }
}
