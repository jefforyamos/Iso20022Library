﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndexPoints.  ISO2002 ID# _ASFIpOwOEd-sn-FiNtktcA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat23Choice;

/// <summary>
/// Price expressed as an index points.
/// </summary>
public partial record IndexPoints : IPriceFormat23Choice
{
    public required IsoDecimalNumber Value { get; init; }
}
