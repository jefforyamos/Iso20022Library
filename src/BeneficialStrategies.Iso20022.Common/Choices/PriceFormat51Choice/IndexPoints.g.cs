﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndexPoints.  ISO2002 ID# _XAPfc0GNEeWqy4niLuXETA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat51Choice;

/// <summary>
/// Price expressed as an index points.
/// </summary>
public partial record IndexPoints : PriceFormat51Choice_
{
    public required IsoDecimalNumber Value { get; init; }
}
