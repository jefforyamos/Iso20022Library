﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _JgUNAEHaEeamVPoS58KxXA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ConditionallyAcceptedStatusReason3Choice;

/// <summary>
/// Conditionally accepted reason expressed as a code.
/// </summary>
public partial record Code : IConditionallyAcceptedStatusReason3Choice
{
    public required ConditionallyAcceptedStatusReason2Code Value { get; init; }
}
