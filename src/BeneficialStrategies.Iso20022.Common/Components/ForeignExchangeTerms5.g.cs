﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ForeignExchangeTerms5.  ISO2002 ID# _U4D5Itp-Ed-ak6NoX_4Aeg_-722166527.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information needed to process a currency exchange or conversion.
/// </summary>
public partial record ForeignExchangeTerms5
{
    #nullable enable
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    public required CurrencyCode UnitCurrency { get; init; } 
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    public required CurrencyCode QuotedCurrency { get; init; } 
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
    public PartyIdentification2Choice_? QuotingInstitution { get; init; } 
    
    #nullable disable
}
