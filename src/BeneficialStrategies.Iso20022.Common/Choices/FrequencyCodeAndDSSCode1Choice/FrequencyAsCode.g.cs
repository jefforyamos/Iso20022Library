﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FrequencyAsCode.  ISO2002 ID# _Q7Vk5tp-Ed-ak6NoX_4Aeg_1533373116.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FrequencyCodeAndDSSCode1Choice;

/// <summary>
/// Frequency expressed as a code.
/// </summary>
public partial record FrequencyAsCode : FrequencyCodeAndDSSCode1Choice_
{
    public required EventFrequency1Code Value { get; init; }
}
