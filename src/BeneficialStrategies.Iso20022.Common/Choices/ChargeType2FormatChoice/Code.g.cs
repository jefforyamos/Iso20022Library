﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Rl0FRdp-Ed-ak6NoX_4Aeg_-1541781007.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ChargeType2FormatChoice;

/// <summary>
/// Standard code to specify the type of charge.
/// </summary>
public partial record Code : IChargeType2FormatChoice
{
    public required ChargeType14Code Value { get; init; }
}
