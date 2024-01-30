﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ForeignExchangeTerms10.  ISO2002 ID# _WKBQTtp-Ed-ak6NoX_4Aeg_-117785638.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed to process a currency exchange or conversion.
/// </summary>
public partial record ForeignExchangeTerms10
{
    #nullable enable
    
    /// <summary>
    /// Cash amount resulting from a foreign exchange trade.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAnd13DecimalAmount? ToAmount { get; init; } 
    /// <summary>
    /// Cash amount for which a foreign exchange is required.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? FromAmount { get; init; } 
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
    
    #nullable disable
}
