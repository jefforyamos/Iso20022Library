﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _YIsyIzm_EeWV5sr121Fc8A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Frequency23Choice;

/// <summary>
/// Frequency expressed as an ISO 20022 code.
/// </summary>
public partial record Code : Frequency23Choice_
{
    public required EventFrequency3Code Value { get; init; }
}
