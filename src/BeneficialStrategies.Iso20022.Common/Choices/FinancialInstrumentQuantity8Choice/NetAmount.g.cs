﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NetAmount.  ISO2002 ID# _RhC6ANp-Ed-ak6NoX_4Aeg_1589726639.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity8Choice;

/// <summary>
/// Amount of money remaining after deduction of charges, commissions and taxes and used to determine the quantity of investment fund units to be subscribed.|[Quantity * Price].
/// </summary>
public partial record NetAmount : IFinancialInstrumentQuantity8Choice
{
    public required IsoActiveOrHistoricCurrencyAndAmount Value { get; init; }
}
