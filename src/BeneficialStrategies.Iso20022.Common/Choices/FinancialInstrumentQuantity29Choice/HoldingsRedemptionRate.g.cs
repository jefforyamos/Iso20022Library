﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for HoldingsRedemptionRate.  ISO2002 ID# _52gva0_3Eea1ZIrmU5dI3w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity29Choice;

/// <summary>
/// Portion of the investor's holdings to be redeemed.
/// </summary>
public partial record HoldingsRedemptionRate : IFinancialInstrumentQuantity29Choice
{
    public required IsoPercentageRate Value { get; init; }
}
