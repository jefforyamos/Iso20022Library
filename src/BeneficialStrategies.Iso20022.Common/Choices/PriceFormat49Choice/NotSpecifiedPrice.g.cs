﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedPrice.  ISO2002 ID# _qTz790ELEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat49Choice;

/// <summary>
/// Value of the price not specified.
/// </summary>
public partial record NotSpecifiedPrice : PriceFormat49Choice_
{
    public required PriceValueType9Code Value { get; init; }
}
