﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndCurrencyExchangeDetails4.  ISO2002 ID# _SWFrptp-Ed-ak6NoX_4Aeg_-2139849046.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original amount and currency exchange.
/// </summary>
public partial record AmountAndCurrencyExchangeDetails4
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of amount.
    /// </summary>
    public required IsoMax35Text Type { get; init; } 
    /// <summary>
    /// Amount of money to be exchanged against another amount of money in the counter currency.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Set of elements used to provide details on the currency exchange.
    /// </summary>
    public CurrencyExchange5? CurrencyExchange { get; init; } 
    
    #nullable disable
}
