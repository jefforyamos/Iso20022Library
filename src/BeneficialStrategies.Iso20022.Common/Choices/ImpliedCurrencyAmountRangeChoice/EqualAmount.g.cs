﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for EqualAmount.  ISO2002 ID# _PVH1Adp-Ed-ak6NoX_4Aeg_-1174057054.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ImpliedCurrencyAmountRangeChoice;

/// <summary>
/// Exact value an amount must match to be considered valid.
/// </summary>
public partial record EqualAmount : IImpliedCurrencyAmountRangeChoice
{
    public required IsoImpliedCurrencyAndAmount Value { get; init; }
}
