﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedRate.  ISO2002 ID# _UOfXsdp-Ed-ak6NoX_4Aeg_465503304.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TaxCreditRateFormat1Choice;

/// <summary>
/// Value of the rate not specified.
/// </summary>
public partial record NotSpecifiedRate : ITaxCreditRateFormat1Choice
{
    public required RateValueType6Code Value { get; init; }
}
