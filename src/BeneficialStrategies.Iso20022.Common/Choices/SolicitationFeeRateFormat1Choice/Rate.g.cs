﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _UOMcyNp-Ed-ak6NoX_4Aeg_-1016908277.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SolicitationFeeRateFormat1Choice;

/// <summary>
/// Value is expressed as a rate.
/// </summary>
public partial record Rate : SolicitationFeeRateFormat1Choice_
{
    public required IsoPercentageRate Value { get; init; }
}
