﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _PDp_YeXsEemEj48jhmlA0Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType77Choice;

/// <summary>
/// Standard code to specify the type of net dividend rate.
/// </summary>
public partial record Code : RateType77Choice_
{
    public required NetDividendRateType6Code Value { get; init; }
}
