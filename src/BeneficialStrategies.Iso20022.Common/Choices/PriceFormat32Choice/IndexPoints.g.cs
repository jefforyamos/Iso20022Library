﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndexPoints.  ISO2002 ID# __oPVpCXoEeO4bIO_HtGo9Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat32Choice;

/// <summary>
/// Price expressed in index points.
/// </summary>
public partial record IndexPoints : IPriceFormat32Choice
{
    public required IsoDecimalNumber Value { get; init; }
}
