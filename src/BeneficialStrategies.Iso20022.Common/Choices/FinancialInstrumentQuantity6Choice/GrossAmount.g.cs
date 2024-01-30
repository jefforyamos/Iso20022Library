﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for GrossAmount.  ISO2002 ID# _SoaxwNp-Ed-ak6NoX_4Aeg_-1931220720.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity6Choice;

/// <summary>
/// Amount of money used to determine the quantity of investment fund units to be subscribed, including all charges, commissions, and tax.
/// </summary>
public partial record GrossAmount : IFinancialInstrumentQuantity6Choice
{
    public required IsoActiveOrHistoricCurrencyAndAmount Value { get; init; }
}
