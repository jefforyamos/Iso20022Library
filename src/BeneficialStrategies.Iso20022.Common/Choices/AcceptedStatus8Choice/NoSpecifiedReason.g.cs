﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _4nT4cUGUEeWqy4niLuXETA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedStatus8Choice;

/// <summary>
/// Reason not specified.
/// </summary>
public partial record NoSpecifiedReason : IAcceptedStatus8Choice
{
    public required NoReasonCode Value { get; init; }
}
