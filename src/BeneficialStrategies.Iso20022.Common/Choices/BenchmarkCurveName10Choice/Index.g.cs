﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Index.  ISO2002 ID# _CWO6wax2Eem81-uIvTF5rQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.BenchmarkCurveName10Choice;

/// <summary>
/// Index name where the underlying is an index.
/// </summary>
public partial record Index : IBenchmarkCurveName10Choice
{
    public required BenchmarkCurveName3Code Value { get; init; }
}
