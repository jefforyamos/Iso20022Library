﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashOption1.  ISO2002 ID# _UDBHg9p-Ed-ak6NoX_4Aeg_330926980.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
public partial record CashOption1
{
    #nullable enable
    
    /// <summary>
    /// Indicates wether it is a debit or a credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Currency of the option.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    public CorporateActionDate5? DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    public CorporateActionAmounts1? AmountDetails { get; init; } 
    /// <summary>
    /// Provides information about a foreign exchange.
    /// </summary>
    public ForeignExchangeTerms8? ExchangeRate { get; init; } 
    
    #nullable disable
}
