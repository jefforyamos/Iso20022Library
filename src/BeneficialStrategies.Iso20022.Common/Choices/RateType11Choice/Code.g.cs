﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q2bPtdp-Ed-ak6NoX_4Aeg_-1984207669.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateType11Choice;

/// <summary>
/// Standard code to specify the type of tax rate.
/// </summary>
public partial record Code : IRateType11Choice
{
    public required TaxType4Code Value { get; init; }
}
