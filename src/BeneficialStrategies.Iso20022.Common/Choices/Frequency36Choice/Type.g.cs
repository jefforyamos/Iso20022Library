﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Type.  ISO2002 ID# _seR6MWk2Eeanu6HLe77Rkg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Frequency36Choice;

/// <summary>
/// Specifies a frequency in terms of a specified period type.
/// </summary>
public partial record Type : IFrequency36Choice
{
    public required Frequency6Code Value { get; init; }
}
