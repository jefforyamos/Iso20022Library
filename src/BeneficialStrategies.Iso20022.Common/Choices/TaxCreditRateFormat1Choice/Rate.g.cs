﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _UOVmvdp-Ed-ak6NoX_4Aeg_539383304.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TaxCreditRateFormat1Choice;

/// <summary>
/// Value is expressed as a rate.
/// </summary>
public partial record Rate : ITaxCreditRateFormat1Choice
{
    public required IsoPercentageRate Value { get; init; }
}
