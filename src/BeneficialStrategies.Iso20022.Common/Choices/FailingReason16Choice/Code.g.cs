﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _-11qYSW-EeygjNFjAlVoPA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FailingReason16Choice;

/// <summary>
/// Specifies the reason why the instruction has a failing settlement status.
/// </summary>
public partial record Code : IFailingReason16Choice
{
    public required FailingReason4Code Value { get; init; }
}
