﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _g4YRUUENEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType39Choice;

/// <summary>
/// Standard code to specify the type of net dividend rate.
/// </summary>
public partial record Code : RateType39Choice_
{
    public required NetDividendRateType2Code Value { get; init; }
}
