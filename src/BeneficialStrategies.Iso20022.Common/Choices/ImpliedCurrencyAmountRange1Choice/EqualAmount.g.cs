﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for EqualAmount.  ISO2002 ID# _O_mxN5lcEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ImpliedCurrencyAmountRange1Choice;

/// <summary>
/// Exact value an amount must match to be considered valid.
/// </summary>
public partial record EqualAmount : ImpliedCurrencyAmountRange1Choice_
{
    public required IsoImpliedCurrencyAndAmount Value { get; init; }
}
