﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndexPoints.  ISO2002 ID# _uQ3rFCXxEeO4bIO_HtGo9Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat34Choice;

/// <summary>
/// Price expressed in index points.
/// </summary>
public partial record IndexPoints : IPriceFormat34Choice
{
    public required IsoDecimalNumber Value { get; init; }
}
