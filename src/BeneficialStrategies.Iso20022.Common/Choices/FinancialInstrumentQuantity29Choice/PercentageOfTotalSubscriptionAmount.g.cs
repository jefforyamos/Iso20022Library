﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PercentageOfTotalSubscriptionAmount.  ISO2002 ID# _52gvZU_3Eea1ZIrmU5dI3w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity29Choice;

/// <summary>
/// Percentage of the total switch amount (buy-driven) to be invested in a particular investment fund or investment fund class.
/// </summary>
public partial record PercentageOfTotalSubscriptionAmount : IFinancialInstrumentQuantity29Choice
{
    public required IsoPercentageRate Value { get; init; }
}
