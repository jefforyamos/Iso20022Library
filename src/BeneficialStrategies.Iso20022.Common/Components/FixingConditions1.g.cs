﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FixingConditions1.  ISO2002 ID# _-eNb8KZqEea16Jw8SEVrDQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the additional information for an NDF as supplied on a fixing instruction.
/// </summary>
public partial record FixingConditions1
{
    #nullable enable
    
    /// <summary>
    /// The date on which the trade was executed.
    /// </summary>
    public required IsoISODate TradeDate { get; init; } 
    /// <summary>
    /// Represents the original reference of the instruction for which the status is given, as assigned by the participant that submitted the foreign exchange trade.
    /// </summary>
    public required IsoMax35Text OriginatorReference { get; init; } 
    /// <summary>
    /// Reference common to both parties of the trade.
    /// </summary>
    public IsoMax35Text? CommonReference { get; init; } 
    /// <summary>
    /// Reference to the identification of a previous event in the life of a trade which is amended or cancelled.
    /// </summary>
    public IsoMax35Text? RelatedReference { get; init; } 
    /// <summary>
    /// Currency and amount bought in a foreign exchange trade.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount TradingSideBuyAmount { get; init; } 
    /// <summary>
    /// Currency and amount sold in a foreign exchange trade.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount TradingSideSellAmount { get; init; } 
    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    
    #nullable disable
}
