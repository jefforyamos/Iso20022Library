﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndexPoints.  ISO2002 ID# _KBddrUEFEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat44Choice;

/// <summary>
/// Price expressed as an index points.
/// </summary>
public partial record IndexPoints : IPriceFormat44Choice
{
    public required IsoDecimalNumber Value { get; init; }
}
