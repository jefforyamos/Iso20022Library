﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _GlS6xWoFEearR-CA7eRZXQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Frequency37Choice;

/// <summary>
/// Frequency expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IFrequency37Choice
{
    public required Frequency10Code Value { get; init; }
}
