﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q2kZoNp-Ed-ak6NoX_4Aeg_655623004.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType7Choice;

/// <summary>
/// Standard code to specify the type of net dividend rate.
/// </summary>
public partial record Code : IRateType7Choice
{
    public required NetDividendRateType1Code Value { get; init; }
}
