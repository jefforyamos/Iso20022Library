﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedRate.  ISO2002 ID# _po6BxeGYEd-1Ktb5rVaajw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat14Choice;

/// <summary>
/// Value of the rate not specified.
/// </summary>
public partial record NotSpecifiedRate : IRateAndAmountFormat14Choice
{
    public required RateValueType7Code Value { get; init; }
}
