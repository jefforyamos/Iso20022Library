﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for GrossAmount.  ISO2002 ID# _52gvaU_3Eea1ZIrmU5dI3w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity29Choice;

/// <summary>
/// Amount of money to be redeemed from the fund. 
/// Gross Amount = Quantity * Price.
/// </summary>
public partial record GrossAmount : FinancialInstrumentQuantity29Choice_
{
    public required IsoActiveOrHistoricCurrencyAndAmount Value { get; init; }
}
