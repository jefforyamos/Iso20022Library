﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _SumZFgEcEeCQm6a_G2yO_w_1522388026.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DiscountTypeFormat1Choice;

/// <summary>
/// Standard code to specify the type of discount.
/// </summary>
public partial record Code : IDiscountTypeFormat1Choice
{
    public required DiscountType1Code Value { get; init; }
}
