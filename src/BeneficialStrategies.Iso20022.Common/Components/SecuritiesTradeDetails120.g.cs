﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesTradeDetails120.  ISO2002 ID# __fex0QyOEeuG8M5giQ2e0w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities trade.
/// </summary>
public partial record SecuritiesTradeDetails120
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
    /// </summary>
    public IsoMax52Text[] TradeIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Unambiguous identification of a collateral transaction as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text[] CollateralTransactionIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    public PlaceOfClearingIdentification2? PlaceOfClearing { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public TradeDate8Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Date and time after the settlement date specified in the trade, used for pool trades resulting from the original To Be Assigned (TBA) securities.
    /// </summary>
    public DateAndDateTime2Choice_? LateDeliveryDate { get; init; } 
    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    public Price10? DealPrice { get; init; } 
    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    public IsoMax3Number? NumberOfDaysAccrued { get; init; } 
    /// <summary>
    /// Specifies additional information relative to the processing of the trade.
    /// </summary>
    public OpeningClosing3Choice_? OpeningClosing { get; init; } 
    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    public Reporting6Choice_[] Reporting { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    public TradeTransactionCondition5Choice_[] TradeTransactionCondition { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the role of the investor in the transaction.
    /// </summary>
    public InvestorCapacity4Choice_? InvestorCapacity { get; init; } 
    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    public TradeOriginator3Choice_? TradeOriginatorRole { get; init; } 
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    public TypeOfPrice29Choice_? TypeOfPrice { get; init; } 
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds or to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; } 
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    public MatchingStatus27Choice_? MatchingStatus { get; init; } 
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    public AffirmationStatus8Choice_? AffirmationStatus { get; init; } 
    /// <summary>
    /// Provides additional details pertaining to foreign exchange instructions.
    /// </summary>
    public IsoMax350Text? FXAdditionalDetails { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    
    #nullable disable
}
