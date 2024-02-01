﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Trade1.  ISO2002 ID# _sJMGoAKMEeStmNeY_LieLw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the treasury trade captured.
/// </summary>
public partial record Trade1
{
    #nullable enable
    
    /// <summary>
    /// Unique reference identification assigned to the trade by the instructing party. This reference will be used throughout the trade life cycle to identify the particular trade.
    /// </summary>
    public required IsoMax35Text TradeIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the trade was executed.
    /// </summary>
    public required IsoISODateTime DateAndTime { get; init; } 
    /// <summary>
    /// Specifies the underlying product type.
    /// </summary>
    public UnderlyingProductIdentifier1Code? ForeignExchangeTradeProduct { get; init; } 
    /// <summary>
    /// Specifies the ISO code of the trade currency.
    /// </summary>
    public CurrencyCode? TradingCurrency { get; init; } 
    /// <summary>
    /// Settlement currency of the trade, agreed by both sides of the trade.
    /// </summary>
    public CurrencyCode? SettlementCurrency { get; init; } 
    /// <summary>
    /// Identifies the type of trading method.
    /// </summary>
    public required TradingMethodType1Code TradingMethod { get; init; } 
    /// <summary>
    /// Identifies the type of the trade mode.
    /// </summary>
    public TradingModeType1Code? TradingMode { get; init; } 
    /// <summary>
    /// Clearing method of the trade, agreed by both sides of the trade.
    /// </summary>
    public required ClearingMethod1Code ClearingMethod { get; init; } 
    /// <summary>
    /// Identifies current status of the trade.
    /// </summary>
    public required OrderStatus8Code ExecutionType { get; init; } 
    /// <summary>
    /// Symbol of the trade.
    /// </summary>
    public required IsoMax35Text Symbol { get; init; } 
    /// <summary>
    /// Infrastructure where the trade confirmation will take place.
    /// </summary>
    public IsoMax35Text? PlaceOfConfirmation { get; init; } 
    /// <summary>
    /// Date and time at which the message was executed.
    /// </summary>
    public IsoISODateTime? TransactionTime { get; init; } 
    /// <summary>
    /// Provides details of the foreign exchange trade including Spot Forward and NDF.
    /// </summary>
    public Trade3? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Provides details about each leg of the multileg instrument (foreign exchange swap).
    /// </summary>
    public InstrumentLeg6[] SwapLeg { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the parameters of the foreign exchange option.
    /// </summary>
    public Option10? Option { get; init; } 
    /// <summary>
    /// Identification of the treasury trade product, as assigned under a formal or proprietary identification scheme.
    /// </summary>
    public SecurityIdentification22Choice_? ProductIdentification { get; init; } 
    
    #nullable disable
}
