﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _HJm3ACCVEeWJd9HF2tO7BA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InformationDistribution1Choice;

/// <summary>
/// Information distribution expressed as a code.
/// </summary>
public partial record Code : InformationDistribution1Choice_
{
    public required InformationDistribution2Code Value { get; init; }
}
