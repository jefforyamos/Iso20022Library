﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndexPoints.  ISO2002 ID# _pVBYj0ELEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat47Choice;

/// <summary>
/// Price expressed in index points.
/// </summary>
public partial record IndexPoints : IPriceFormat47Choice
{
    public required IsoDecimalNumber Value { get; init; }
}
