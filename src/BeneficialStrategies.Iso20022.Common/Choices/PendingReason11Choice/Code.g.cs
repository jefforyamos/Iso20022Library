﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _itAog0AAEeCaq78Ig8ATcA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason11Choice;

/// <summary>
/// Specifies the reason why the instruction has a pending status.
/// </summary>
public partial record Code : IPendingReason11Choice
{
    public required PendingReason8Code Value { get; init; }
}
