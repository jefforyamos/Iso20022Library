﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ckCY7pKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType48Choice;

/// <summary>
/// Standard code to specify the type of tax rate.
/// </summary>
public partial record Code : IRateType48Choice
{
    public required RateType3Code Value { get; init; }
}
