﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _LtxaMTt6EeW638lNyHKv7A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedReason9Choice;

/// <summary>
/// Standard code to specify additional information about the processed instruction.
/// </summary>
public partial record Code : IAcceptedReason9Choice
{
    public required AcknowledgementReason8Code Value { get; init; }
}
