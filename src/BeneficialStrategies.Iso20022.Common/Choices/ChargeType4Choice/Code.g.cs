﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _wTqbsQatEeS3lpTattq7hg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ChargeType4Choice;

/// <summary>
/// Type of charge expressed as a code.
/// </summary>
public partial record Code : IChargeType4Choice
{
    public required ChargeType12Code Value { get; init; }
}
