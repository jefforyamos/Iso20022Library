﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _po6Bw-GYEd-1Ktb5rVaajw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat14Choice;

/// <summary>
/// Value expressed as a rate.
/// </summary>
public partial record Rate : RateAndAmountFormat14Choice_
{
    public required IsoPercentageRate Value { get; init; }
}
