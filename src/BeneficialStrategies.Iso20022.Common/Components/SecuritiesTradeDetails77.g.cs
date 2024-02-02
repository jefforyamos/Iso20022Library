﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesTradeDetails77.  ISO2002 ID# _wttNsbPuEeelzbgsFa3sqQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities trade.
/// </summary>
[DataContract]
[XmlType]
public partial record SecuritiesTradeDetails77
{
    #nullable enable
    
    /// <summary>
    /// Market in which a trade transaction has been executed.
    /// </summary>
    [DataMember]
    public PlaceOfTradeIdentification1? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
    /// </summary>
    [DataMember]
    public PlaceOfClearingIdentification1? PlaceOfClearing { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [DataMember]
    public TradeDate8Choice_? TradeDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [DataMember]
    public required DateAndDateTime2Choice_ OpeningSettlementDate { get; init; } 
    /// <summary>
    /// Specifies the price of the traded financial instrument.|This is the deal price of the individual trade transaction. |If there is only one trade transaction for the execution of the trade, then the deal price could equal the executed trade price (unless, for example, the price includes commissions or rounding, or some other factor has been applied to the deal price or the executed trade price, or both).
    /// </summary>
    [DataMember]
    public Price7? DealPrice { get; init; } 
    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [DataMember]
    public IsoMax3Number? NumberOfDaysAccrued { get; init; } 
    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    [DataMember]
    public ValueList<Reporting6Choice_> Reporting { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [DataMember]
    public ValueList<TradeTransactionCondition5Choice_> TradeTransactionCondition { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the role of the investor in the transaction.
    /// </summary>
    [DataMember]
    public InvestorCapacity4Choice_? InvestorCapacity { get; init; } 
    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    [DataMember]
    public TradeOriginator3Choice_? TradeOriginatorRole { get; init; } 
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds or to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    [DataMember]
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; } 
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [DataMember]
    public AffirmationStatus8Choice_? AffirmationStatus { get; init; } 
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [DataMember]
    public MatchingStatus27Choice_? MatchingStatus { get; init; } 
    /// <summary>
    /// Provides additional settlement processing information which can not be included within the structured fields of the message.
    /// </summary>
    [DataMember]
    public IsoMax350Text? SettlementInstructionProcessingAdditionalDetails { get; init; } 
    /// <summary>
    /// Provides additional details pertaining to foreign exchange instructions.
    /// </summary>
    [DataMember]
    public IsoMax350Text? FXAdditionalDetails { get; init; } 
    
    #nullable disable
}
