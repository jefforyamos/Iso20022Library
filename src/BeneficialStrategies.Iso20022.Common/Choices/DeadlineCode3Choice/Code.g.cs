﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _XGLR0UGZEeWqy4niLuXETA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DeadlineCode3Choice;

/// <summary>
/// Standard code to specify the reference date of a corporate action.
/// </summary>
public partial record Code : IDeadlineCode3Choice
{
    public required CorporateActionDeadline1Code Value { get; init; }
}
