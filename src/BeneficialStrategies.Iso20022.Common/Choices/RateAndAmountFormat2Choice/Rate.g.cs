﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _UPYvltp-Ed-ak6NoX_4Aeg_-1617946453.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat2Choice;

/// <summary>
/// The value is expressed as a rate.
/// </summary>
public partial record Rate : RateAndAmountFormat2Choice_
{
    public required IsoPercentageRate Value { get; init; }
}
