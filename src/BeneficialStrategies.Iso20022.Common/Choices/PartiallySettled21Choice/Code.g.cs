﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _SSiV8UHtEeaNSo9he0Belg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartiallySettled21Choice;

/// <summary>
/// Partially settled reason expressed as a code.
/// </summary>
public partial record Code : IPartiallySettled21Choice
{
    public required SettledStatusReason2Code Value { get; init; }
}
