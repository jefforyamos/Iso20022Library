﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Type.  ISO2002 ID# _POBygBrXEeOVR9VN6fAMUg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AdjustmentType1Choice;

/// <summary>
/// Specifies the type of adjustment applied to the amount of goods/services by means of a code.
/// </summary>
public partial record Type : IAdjustmentType1Choice
{
    public required AdjustmentType2Code Value { get; init; }
}
