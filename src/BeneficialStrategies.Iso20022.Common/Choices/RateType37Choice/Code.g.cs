﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _I8JMkUELEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType37Choice;

/// <summary>
/// Standard code to specify the type of tax rate.
/// </summary>
public partial record Code : RateType37Choice_
{
    public required RateType3Code Value { get; init; }
}
