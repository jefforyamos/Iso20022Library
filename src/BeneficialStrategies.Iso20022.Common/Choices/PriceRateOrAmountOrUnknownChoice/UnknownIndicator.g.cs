﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UnknownIndicator.  ISO2002 ID# _QaaCF9p-Ed-ak6NoX_4Aeg_-1972249999.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceRateOrAmountOrUnknownChoice;

/// <summary>
/// Indicates whether the market price is unknown.
/// </summary>
public partial record UnknownIndicator : IPriceRateOrAmountOrUnknownChoice
{
    public required IsoYesNoIndicator Value { get; init; }
}
