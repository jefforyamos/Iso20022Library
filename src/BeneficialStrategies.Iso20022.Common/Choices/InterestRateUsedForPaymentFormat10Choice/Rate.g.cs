﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _cteBxZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRateUsedForPaymentFormat10Choice;

/// <summary>
/// Value is expressed as a rate.
/// </summary>
public partial record Rate : InterestRateUsedForPaymentFormat10Choice_
{
    public required IsoPercentageRate Value { get; init; }
}
