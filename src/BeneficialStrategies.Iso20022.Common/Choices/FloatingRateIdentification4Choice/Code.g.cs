﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _MBEjcSjFEeuKKc2MztSwPw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FloatingRateIdentification4Choice;

/// <summary>
/// List of floating rate curves.
/// </summary>
public partial record Code : FloatingRateIdentification4Choice_
{
    public required BenchmarkCurveName5Code Value { get; init; }
}
