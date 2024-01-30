﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ForeignExchangeTerms14.  ISO2002 ID# _K14CveaOEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed to process a currency exchange or conversion.
/// </summary>
public partial record ForeignExchangeTerms14
{
    #nullable enable
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode UnitCurrency { get; init; } 
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode QuotedCurrency { get; init; } 
    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    /// <summary>
    /// Date and time at which an exchange rate is quoted.
    /// </summary>
    public IsoISODateTime? QuotationDate { get; init; } 
    /// <summary>
    /// Party that proposes a foreign exchange rate.
    /// </summary>
    public IPartyIdentification49Choice? QuotingInstitution { get; init; } 
    
    #nullable disable
}
