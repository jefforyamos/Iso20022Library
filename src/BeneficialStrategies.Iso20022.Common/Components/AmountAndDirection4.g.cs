﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndDirection4.  ISO2002 ID# _SUJx9tp-Ed-ak6NoX_4Aeg_-412561775.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money debited or credited on the books of an account servicer.
/// </summary>
public partial record AmountAndDirection4
{
    #nullable enable
    
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    
    #nullable disable
}
