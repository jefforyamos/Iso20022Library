﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndDirection27.  ISO2002 ID# _-dAcO6MOEeCojJW5vEuTEQ_-722507688.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money debited or credited on the books of an account servicer.
/// </summary>
public partial record AmountAndDirection27
{
    #nullable enable
    
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Posting/settlement amount in its original currency when conversion from/into another currency has occurred.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? OriginalCurrencyAndOrderedAmount { get; init; } 
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    public ForeignExchangeTerms17? ForeignExchangeDetails { get; init; } 
    
    #nullable disable
}
