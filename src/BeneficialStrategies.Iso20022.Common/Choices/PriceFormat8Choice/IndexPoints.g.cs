﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndexPoints.  ISO2002 ID# _Q2bPsNp-Ed-ak6NoX_4Aeg_1850641628.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat8Choice;

/// <summary>
/// Price expressed as an index points.
/// </summary>
public partial record IndexPoints : IPriceFormat8Choice
{
    public required IsoDecimalNumber Value { get; init; }
}
