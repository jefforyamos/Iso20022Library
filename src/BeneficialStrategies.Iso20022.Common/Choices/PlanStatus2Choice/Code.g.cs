﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ZRAiMSFOEeWgV9SQSyaAog.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PlanStatus2Choice;

/// <summary>
/// Status of the plan expressed as a code.
/// </summary>
public partial record Code : IPlanStatus2Choice
{
    public required PlanStatus1Code Value { get; init; }
}
