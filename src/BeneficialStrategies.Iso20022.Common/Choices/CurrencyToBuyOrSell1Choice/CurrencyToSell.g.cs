﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CurrencyToSell.  ISO2002 ID# _QsvIM9p-Ed-ak6NoX_4Aeg_-894055934.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CurrencyToBuyOrSell1Choice;

/// <summary>
/// Account servicer is instructed to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
/// </summary>
public partial record CurrencyToSell : CurrencyToBuyOrSell1Choice_
{
    public required ActiveCurrencyCode Value { get; init; }
}
