﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesTradeDetails37.  ISO2002 ID# _tm-gcStKEeOgfbujmhmNAA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities trade.
/// </summary>
public partial record SecuritiesTradeDetails37
{
    #nullable enable
    
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    public MarketIdentification78? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and wich facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    public IsoAnyBICIdentifier? PlaceOfClearing { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public TradeDate1Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public required DateAndDateTimeChoice_ OpeningSettlementDate { get; init; } 
    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    public Price2? DealPrice { get; init; } 
    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    public IsoMax3Number? NumberOfDaysAccrued { get; init; } 
    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    public Reporting2Choice_[] Reporting { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    public TradeTransactionCondition1Choice_[] TradeTransactionCondition { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the role of the investor in the transaction.
    /// </summary>
    public InvestorCapacity1Choice_? InvestorCapacity { get; init; } 
    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    public TradeOriginator1Choice_? TradeOriginatorRole { get; init; } 
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds or to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; } 
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    public AffirmationStatus1Choice_? AffirmationStatus { get; init; } 
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    public MatchingStatus1Choice_? MatchingStatus { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    /// <summary>
    /// Provides additional details pertaining to foreign exchange instructions.
    /// </summary>
    public IsoMax350Text? FXAdditionalDetails { get; init; } 
    
    #nullable disable
}
