﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedPrice.  ISO2002 ID# _SDqHYQ-zEeuE0Pnt-OcNOA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat63Choice;

/// <summary>
/// Value of the price not specified.
/// </summary>
public partial record NotSpecifiedPrice : IPriceFormat63Choice
{
    public required PriceValueType13Code Value { get; init; }
}
