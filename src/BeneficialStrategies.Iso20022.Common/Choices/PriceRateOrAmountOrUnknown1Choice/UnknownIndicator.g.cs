﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UnknownIndicator.  ISO2002 ID# _Wi6RYdp-Ed-ak6NoX_4Aeg_-1982209591.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmountOrUnknown1Choice;

/// <summary>
/// Indicates whether the market price is unknown.
/// </summary>
public partial record UnknownIndicator : IPriceRateOrAmountOrUnknown1Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
