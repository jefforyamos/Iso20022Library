﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NetAmount.  ISO2002 ID# _ZipfBThUEeaRwdGFv45qTQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity28Choice;

/// <summary>
/// Amount of money to be received following redemption of fund units. 
/// Net Amount = (Quantity * Price) - (Fees + Taxes).
/// </summary>
public partial record NetAmount : FinancialInstrumentQuantity28Choice_
{
    public required IsoActiveOrHistoricCurrencyAndAmount Value { get; init; }
}
