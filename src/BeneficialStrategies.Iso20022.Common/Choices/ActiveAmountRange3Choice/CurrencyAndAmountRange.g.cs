﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CurrencyAndAmountRange.  ISO2002 ID# _OvM9tZlcEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ActiveAmountRange3Choice;

/// <summary>
/// Expresses an amount or an amount range with the currency and where the credit/debit indicator is explicit.
/// </summary>
public partial record CurrencyAndAmountRange : IActiveAmountRange3Choice
{
    #nullable enable
    /// <summary>
    /// Specified amount or amount range.
    /// </summary>
    public required IImpliedCurrencyAmountRange1Choice Amount { get; init; } 
    /// <summary>
    /// Indicates whether the amount is a credited or debited amount.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Medium of exchange of value, used to qualify an amount.
    /// </summary>
    public required ActiveCurrencyCode Currency { get; init; } 
    #nullable disable
}
