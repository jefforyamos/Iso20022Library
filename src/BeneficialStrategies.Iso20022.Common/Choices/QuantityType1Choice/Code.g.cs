﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _2-19cQaxEeS3lpTattq7hg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.QuantityType1Choice;

/// <summary>
/// Quantity type expressed as a code.
/// </summary>
public partial record Code : QuantityType1Choice_
{
    public required OrderQuantityType2Code Value { get; init; }
}
