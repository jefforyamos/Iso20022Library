﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _Wf3Xo0EIEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxCreditRateFormat7Choice;

/// <summary>
/// Value expressed as a rate.
/// </summary>
public partial record Rate : ITaxCreditRateFormat7Choice
{
    public required IsoPercentageRate Value { get; init; }
}
