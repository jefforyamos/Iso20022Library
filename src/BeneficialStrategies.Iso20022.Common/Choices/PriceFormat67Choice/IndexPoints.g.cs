﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndexPoints.  ISO2002 ID# _pi0DKji7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat67Choice;

/// <summary>
/// Price expressed in index points.
/// </summary>
public partial record IndexPoints : IPriceFormat67Choice
{
    public required IsoRestrictedFINDecimalNumber Value { get; init; }
}
