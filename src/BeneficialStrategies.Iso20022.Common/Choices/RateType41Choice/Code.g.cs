﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _jk4GEUEIEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType41Choice;

/// <summary>
/// Standard code to specify the type of net dividend rate.
/// </summary>
public partial record Code : IRateType41Choice
{
    public required NetDividendRateType3Code Value { get; init; }
}
