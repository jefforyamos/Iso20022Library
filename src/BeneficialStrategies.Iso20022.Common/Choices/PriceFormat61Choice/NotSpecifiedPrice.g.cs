﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedPrice.  ISO2002 ID# _4doifJbREee8S7xwGG7Veg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat61Choice;

/// <summary>
/// Value of the price not specified.
/// </summary>
public partial record NotSpecifiedPrice : IPriceFormat61Choice
{
    public required PriceValueType10Code Value { get; init; }
}
