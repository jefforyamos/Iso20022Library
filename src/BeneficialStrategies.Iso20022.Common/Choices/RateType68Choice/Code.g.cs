﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _zoSyEZb7Eee8S7xwGG7Veg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RateType68Choice;

/// <summary>
/// Standard code to specify the type of gross dividend rate.
/// </summary>
public partial record Code : IRateType68Choice
{
    public required GrossDividendRateType4Code Value { get; init; }
}
