﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedRate.  ISO2002 ID# _UPF0oNp-Ed-ak6NoX_4Aeg_-1134635694.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat4Choice;

/// <summary>
/// Value of the rate not specified.
/// </summary>
public partial record NotSpecifiedRate : IRateAndAmountFormat4Choice
{
    public required RateValueType6Code Value { get; init; }
}
