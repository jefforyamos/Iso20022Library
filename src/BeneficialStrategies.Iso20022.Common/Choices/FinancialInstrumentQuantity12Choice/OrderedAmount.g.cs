﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OrderedAmount.  ISO2002 ID# _RgvYBNp-Ed-ak6NoX_4Aeg_799651867.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity12Choice;

/// <summary>
/// Amount of money used to derive the quantity of investment fund units to be sold.
/// </summary>
public partial record OrderedAmount : IFinancialInstrumentQuantity12Choice
{
    public required IsoActiveOrHistoricCurrencyAndAmount Value { get; init; }
}
