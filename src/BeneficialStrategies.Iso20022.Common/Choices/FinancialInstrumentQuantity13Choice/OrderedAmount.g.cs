﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OrderedAmount.  ISO2002 ID# _RgSsEdp-Ed-ak6NoX_4Aeg_814428807.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity13Choice;

/// <summary>
/// Amount of money used to determine the quantity of investment fund units to be subscribed.
/// </summary>
public partial record OrderedAmount : IFinancialInstrumentQuantity13Choice
{
    public required IsoActiveOrHistoricCurrencyAndAmount Value { get; init; }
}
