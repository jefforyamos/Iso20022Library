﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Order23.  ISO2002 ID# _6GFykQauEe2phaVG0lYKTw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intention to transfer an ownership of a financial instrument.
/// </summary>
public partial record Order23
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of business process.
    /// </summary>
    public BusinessProcessType2Choice_? BusinessProcessType { get; init; } 
    /// <summary>
    /// Unique identifier for Order as assigned by sell-side.
    /// </summary>
    public IsoMax35Text[] OrderIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Unique identifier for the order as assigned by the buy-side. Uniqueness must be guaranteed within a single trading day. Firms, particularly those that electronically submit multi-day orders, trade globally or throughout market close periods, should ensure uniqueness across days, for example by embedding a date within the ClientOrderIdentification element.
    /// </summary>
    public IsoMax35Text[] ClientOrderIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Assigned by the party that originates the order. Can be used to provide the ClientOrderIdentification used by an exchange or executing system.
    /// </summary>
    public IsoMax35Text[] SecondaryClientOrderIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Unique identifier for a list, as assigned by the trading party. The identifier must be unique within a single trading day.
    /// </summary>
    public IsoMax35Text[] ListIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Unique and unambiguous identifier of a financial instrument, assigned under a formal or proprietary identification scheme.
    /// </summary>
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Coded list to specify the side of the order.
    /// </summary>
    public required Side3Code Side { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    public DeliveryReceiptType2Code? Payment { get; init; } 
    /// <summary>
    /// Specifies the type of transaction of which the order is a component.
    /// </summary>
    public TradeType4Choice_? TradeTransactionType { get; init; } 
    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    public TradeTransactionCondition9Choice_[] TradeTransactionCondition { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Transaction is a pre-advice, that is, for matching purposes only.
    /// </summary>
    public IsoYesNoIndicator? PreAdvice { get; init; } 
    /// <summary>
    /// Market in which a trade transaction is to be or has been executed.
    /// </summary>
    public MarketIdentification93? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer's books.
    /// </summary>
    public IsoISODate? OrderBookingDate { get; init; } 
    /// <summary>
    /// Indicates the date and time of the agreement in principal between counter-parties prior to actual trade date.|Used with fixed income for municipal new issue markets.
    /// </summary>
    public IsoISODateTime? TradeOriginationDate { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public required TradeDate7Choice_ TradeDate { get; init; } 
    /// <summary>
    /// Processing date of the trading session.
    /// </summary>
    public TradeDate7Choice_? ProcessingDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    public required SettlementDate16Choice_ SettlementDate { get; init; } 
    /// <summary>
    /// Valuation point, or valuation date of the portfolio (underlying assets). This is also known as price date.
    /// </summary>
    public DateAndDateTime1Choice_? NAVDate { get; init; } 
    /// <summary>
    /// Quantity of financial instrument bought or sold which is less than the quantity of financial instrument ordered.
    /// </summary>
    public PartialFill4[] PartialFillDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Quantity of financial instrument that is being confirmed for the account.The quantity of the security to be settled.
    /// </summary>
    public required Quantity6Choice_ ConfirmationQuantity { get; init; } 
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series, etc.
    /// </summary>
    public QuantityBreakdown76[] QuantityBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    public AmountAndDirection29? GrossTradeAmount { get; init; } 
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    public required Price14 DealPrice { get; init; } 
    /// <summary>
    /// Specifies the type of transaction price.
    /// </summary>
    public TypeOfPrice47Choice_? TypeOfPrice { get; init; } 
    /// <summary>
    /// Identifies whether an order is a margin order or a non-margin order. This is primarily used when sending orders to Japanese exchanges to indicate sell margin or buy to cover. The same tag could be assigned also by buy-side to indicate the intent to sell or buy margin and the sell-side to accept or reject (base on some validation criteria) the margin request.
    /// </summary>
    public CashMarginOrder1Code? CashMargin { get; init; } 
    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    public Commission25? Commission { get; init; } 
    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    public IsoMax3Number? NumberOfDaysAccrued { get; init; } 
    /// <summary>
    /// Specifies the number of days from trade date that the counterparty on the other side of the trade should be "given up" or divulged.
    /// </summary>
    public IsoMax3Number? GiveUpNumberOfDays { get; init; } 
    /// <summary>
    /// Indicates whether the trade is cum interest or ex interest.
    /// </summary>
    public InterestType2Code? InterestType { get; init; } 
    /// <summary>
    /// Interest rate that has been accrued in between coupon payment periods.
    /// </summary>
    public IsoPercentageRate? AccruedInterestPercentage { get; init; } 
    /// <summary>
    /// Specifies the regulatory conditions type of the trade.
    /// </summary>
    public TradeRegulatoryConditions1Code? TradeRegulatoryConditionsType { get; init; } 
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds or to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; } 
    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    public Eligibility1Code? OrderOriginatorEligibility { get; init; } 
    /// <summary>
    /// Indicates whether the resulting position after a trade should be an opening position or closing position. Used for omnibus accounting - where accounts are held on a gross basis instead of being netted together.
    /// </summary>
    public PositionEffect2Code? PositionEffect { get; init; } 
    /// <summary>
    /// Indicates whether the derivative product is covered or not by an underlying financial instrument position.
    /// </summary>
    public IsoYesNoIndicator? DerivativeCovered { get; init; } 
    /// <summary>
    /// Type of charge/tax basis.
    /// </summary>
    public ChargeTaxBasisType2Choice_? ChargeTaxBasisType { get; init; } 
    /// <summary>
    /// Specifies the type of capital gain.
    /// </summary>
    public EUCapitalGainType3Choice_? CapitalGainType { get; init; } 
    /// <summary>
    /// Provides the matching status of the trade confirmation.
    /// </summary>
    public MatchingStatus27Choice_? MatchStatus { get; init; } 
    /// <summary>
    /// Specifies the type of pay-in call report.
    /// </summary>
    public CallIn1Code? CallInType { get; init; } 
    /// <summary>
    /// Type of yield at which the transaction was effected.
    /// </summary>
    public YieldCalculation7? YieldType { get; init; } 
    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    public Reporting6Choice_[] Reporting { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    public RegistrationParameters3? AdditionalPhysicalOrRegistrationDetails { get; init; } 
    /// <summary>
    /// Provides additional details of the trade process not included within structured fields of this message.
    /// </summary>
    public IsoMax350Text? AdditionalTradeInstructionProcessingInformation { get; init; } 
    /// <summary>
    /// Interest amount that has accrued in between two periods, for example, in between interest payment periods.
    /// </summary>
    public AmountAndDirection29? AccruedInterestAmount { get; init; } 
    
    #nullable disable
}
