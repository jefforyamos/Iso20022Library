﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedRate.  ISO2002 ID# _ahHhReXsEemEj48jhmlA0Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat38Choice;

/// <summary>
/// Value of the rate not specified.
/// </summary>
public partial record NotSpecifiedRate : IGrossDividendRateFormat38Choice
{
    public required RateType13Code Value { get; init; }
}
