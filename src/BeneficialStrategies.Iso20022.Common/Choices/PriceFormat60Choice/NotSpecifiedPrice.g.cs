﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedPrice.  ISO2002 ID# _ctkvU5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat60Choice;

/// <summary>
/// Value of the price not specified.
/// </summary>
public partial record NotSpecifiedPrice : IPriceFormat60Choice
{
    public required PriceValueType8Code Value { get; init; }
}
