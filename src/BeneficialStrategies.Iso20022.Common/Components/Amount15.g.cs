﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Amount15.  ISO2002 ID# _WfYR0ZFyEeukDPgU2BMkjQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount, currency, exchange rate and quotation date.
/// </summary>
public partial record Amount15
{
    #nullable enable
    
    /// <summary>
    /// Amount exclusive of currency.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Currency code associated with the applicable type of amount.  ISO 4217 "Codes for the representation of currencies and funds".
    /// </summary>
    public ISO3NumericCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// The factor used in the conversion from one amount to another amount.
    /// </summary>
    public IsoBaseOne25Rate? EffectiveExchangeRate { get; init; } 
    /// <summary>
    /// Date at which the exchange rate effective.
    /// </summary>
    public IsoISODate? ConversionDate { get; init; } 
    /// <summary>
    /// Time at which the exchange rate effective.
    /// </summary>
    public IsoISOTime? ConversionTime { get; init; } 
    
    #nullable disable
}
