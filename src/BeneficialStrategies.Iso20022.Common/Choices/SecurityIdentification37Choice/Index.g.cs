﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Index.  ISO2002 ID# _PDXK9TLlEeu9CrLaMVTofw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification37Choice;

/// <summary>
/// Index name where the underlying is an index.
/// </summary>
public partial record Index : SecurityIdentification37Choice_
{
    public required BenchmarkCurveName5Code Value { get; init; }
}
