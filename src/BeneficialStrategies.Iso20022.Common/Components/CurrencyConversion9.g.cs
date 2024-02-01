﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CurrencyConversion9.  ISO2002 ID# _NQ4Zga16EeWMg5rOByfExw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency conversion accepted by the customer, either to convert the amount to dispense in the base currency of the ATM, or to convert the total requested amount in the currency of the customer (so called dynamic currency conversion).
/// </summary>
public partial record CurrencyConversion9
{
    #nullable enable
    
    /// <summary>
    /// Identification of the currency conversion operation.
    /// </summary>
    public IsoMax35Text? CurrencyConversionIdentification { get; init; } 
    /// <summary>
    /// Currency into which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    public required CurrencyDetails2 TargetCurrency { get; init; } 
    /// <summary>
    /// Amount converted in the target currency, including commission and mark-up.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount ResultingAmount { get; init; } 
    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the original amount into the resulting amount.
    /// </summary>
    public required IsoPercentageRate ExchangeRate { get; init; } 
    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the resulting amount into the original amount.
    /// </summary>
    public IsoPercentageRate? InvertedExchangeRate { get; init; } 
    /// <summary>
    /// Date and time at which the exchange rate has been quoted.
    /// </summary>
    public IsoISODateTime? QuotationDate { get; init; } 
    /// <summary>
    /// Validity limit of the exchange rate.
    /// </summary>
    public IsoISODateTime? ValidUntil { get; init; } 
    /// <summary>
    /// Currency from which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    public required CurrencyDetails2 SourceCurrency { get; init; } 
    /// <summary>
    /// Original amount in the source currency.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount OriginalAmount { get; init; } 
    /// <summary>
    /// Commission or additional charges made as part of a currency conversion.
    /// </summary>
    public Commission19[] CommissionDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Mark-up made as part of a currency conversion.
    /// </summary>
    public Commission18[] MarkUpDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Card scheme declaration (disclaimer) to present to the cardholder.
    /// </summary>
    public ActionMessage5? DeclarationDetails { get; init; } 
    
    #nullable disable
}
