﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedRate.  ISO2002 ID# _XFqMbUEIEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxCreditRateFormat8Choice;

/// <summary>
/// Value of the rate not specified.
/// </summary>
public partial record NotSpecifiedRate : TaxCreditRateFormat8Choice_
{
    public required RateValueType7Code Value { get; init; }
}
