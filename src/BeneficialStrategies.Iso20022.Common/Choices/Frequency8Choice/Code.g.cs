﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _m_7dcPNBEeCuA5Tr22BnwA_122827409.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Frequency8Choice;

/// <summary>
/// Frequency expressed in coded form.
/// </summary>
public partial record Code : IFrequency8Choice
{
    public required EventFrequency1Code Value { get; init; }
}
