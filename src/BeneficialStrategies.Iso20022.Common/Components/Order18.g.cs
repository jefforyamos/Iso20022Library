﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Order18.  ISO2002 ID# _jMAsgTAjEeOUGqA1wUwNLA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Intention to transfer an ownership of a financial instrument.
/// </summary>
[IsoId("_jMAsgTAjEeOUGqA1wUwNLA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Order")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Order18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Order18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Order18( SecurityIdentification14 reqFinancialInstrumentIdentification,Side3Code reqSide,TradeDate4Choice_ reqTradeDate,SettlementDate8Choice_ reqSettlementDate,Quantity6Choice_ reqConfirmationQuantity,Price4 reqDealPrice )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        Side = reqSide;
        TradeDate = reqTradeDate;
        SettlementDate = reqSettlementDate;
        ConfirmationQuantity = reqConfirmationQuantity;
        DealPrice = reqDealPrice;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of business process.
    /// </summary>
    [IsoId("_jkHDeTAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Business Process Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BusinessProcessType1Choice_? BusinessProcessType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessProcessType1Choice_? BusinessProcessType { get; init; } 
    #else
    public BusinessProcessType1Choice_? BusinessProcessType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for Order as assigned by sell-side.
    /// </summary>
    [IsoId("_jkHDezAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Order Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OrderIdentification { get; init; } 
    #else
    public System.String? OrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for the order as assigned by the buy-side. Uniqueness must be guaranteed within a single trading day. Firms, particularly those that electronically submit multi-day orders, trade globally or throughout market close periods, should ensure uniqueness across days, for example by embedding a date within the ClientOrderIdentification element.
    /// </summary>
    [IsoId("_jkHDgzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Client Order Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientOrderIdentification { get; init; } 
    #else
    public System.String? ClientOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Assigned by the party that originates the order. Can be used to provide the ClientOrderIdentification used by an exchange or executing system.
    /// </summary>
    [IsoId("_jkHDizAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Secondary Client Order Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecondaryClientOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecondaryClientOrderIdentification { get; init; } 
    #else
    public System.String? SecondaryClientOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for a list, as assigned by the trading party. The identifier must be unique within a single trading day.
    /// </summary>
    [IsoId("_jkHDkzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("List Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ListIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ListIdentification { get; init; } 
    #else
    public System.String? ListIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial instrument, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_jkHDmzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Financial Instrument Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Coded list to specify the side of the order.
    /// </summary>
    [IsoId("_jkHDnTAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Side")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Side3Code Side { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Side3Code Side { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Side3Code Side { get; init; } 
    #else
    public Side3Code Side { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_jkHDpTAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryReceiptType2Code? Payment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryReceiptType2Code? Payment { get; init; } 
    #else
    public DeliveryReceiptType2Code? Payment { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of transaction of which the order is a component.
    /// </summary>
    [IsoId("_jkHDszAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Transaction Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeType3Choice_? TradeTransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeType3Choice_? TradeTransactionType { get; init; } 
    #else
    public TradeType3Choice_? TradeTransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_jkHDtTAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Transaction Condition")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeTransactionCondition4Choice_? TradeTransactionCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransactionCondition4Choice_? TradeTransactionCondition { get; init; } 
    #else
    public TradeTransactionCondition4Choice_? TradeTransactionCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction is a pre-advice, that is, for matching purposes only.
    /// </summary>
    [IsoId("_jkHDvTAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pre Advice")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PreAdvice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreAdvice { get; init; } 
    #else
    public System.String? PreAdvice { get; set; } 
    #endif
    
    /// <summary>
    /// Market in which a trade transaction is to be or has been executed.
    /// </summary>
    [IsoId("_jkHDvzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Place Of Trade")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification79? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification79? PlaceOfTrade { get; init; } 
    #else
    public MarketIdentification79? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer's books.
    /// </summary>
    [IsoId("_jkHDwTAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Order Booking Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? OrderBookingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? OrderBookingDate { get; init; } 
    #else
    public System.DateOnly? OrderBookingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and time of the agreement in principal between counter-parties prior to actual trade date.|Used with fixed income for municipal new issue markets.
    /// </summary>
    [IsoId("_jkHDwzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Origination Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TradeOriginationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TradeOriginationDate { get; init; } 
    #else
    public System.DateTime? TradeOriginationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_jkHDyzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeDate4Choice_ TradeDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TradeDate4Choice_ TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDate4Choice_ TradeDate { get; init; } 
    #else
    public TradeDate4Choice_ TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Processing date of the trading session.
    /// </summary>
    [IsoId("_jkHD0zAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processing Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeDate4Choice_? ProcessingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDate4Choice_? ProcessingDate { get; init; } 
    #else
    public TradeDate4Choice_? ProcessingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_jkHD1TAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDate8Choice_ SettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SettlementDate8Choice_ SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDate8Choice_ SettlementDate { get; init; } 
    #else
    public SettlementDate8Choice_ SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation point, or valuation date of the portfolio (underlying assets). This is also known as price date.
    /// </summary>
    [IsoId("_jkHD3TAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("NAV Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime1Choice_? NAVDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime1Choice_? NAVDate { get; init; } 
    #else
    public DateAndDateTime1Choice_? NAVDate { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument bought or sold which is less than the quantity of financial instrument ordered.
    /// </summary>
    [IsoId("_jkHD3zAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Partial Fill Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartialFill2? PartialFillDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartialFill2? PartialFillDetails { get; init; } 
    #else
    public PartialFill2? PartialFillDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument that is being confirmed for the account.The quantity of the security to be settled.
    /// </summary>
    [IsoId("_jkHD4TAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Confirmation Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity6Choice_ ConfirmationQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Quantity6Choice_ ConfirmationQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity6Choice_ ConfirmationQuantity { get; init; } 
    #else
    public Quantity6Choice_ ConfirmationQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series, etc.
    /// </summary>
    [IsoId("_jkHD4zAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Quantity Breakdown")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityBreakdown11? QuantityBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityBreakdown11? QuantityBreakdown { get; init; } 
    #else
    public QuantityBreakdown11? QuantityBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_jkHD5TAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Gross Trade Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? GrossTradeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? GrossTradeAmount { get; init; } 
    #else
    public AmountAndDirection29? GrossTradeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_jkHD5zAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Deal Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Price4 DealPrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Price4 DealPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price4 DealPrice { get; init; } 
    #else
    public Price4 DealPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of transaction price.
    /// </summary>
    [IsoId("_jkHD6TAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type Of Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfPrice10Choice_? TypeOfPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice10Choice_? TypeOfPrice { get; init; } 
    #else
    public TypeOfPrice10Choice_? TypeOfPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether an order is a margin order or a non-margin order. This is primarily used when sending orders to Japanese exchanges to indicate sell margin or buy to cover. The same tag could be assigned also by buy-side to indicate the intent to sell or buy margin and the sell-side to accept or reject (base on some validation criteria) the margin request.
    /// </summary>
    [IsoId("_jkHD6zAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Margin")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashMarginOrder1Code? CashMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashMarginOrder1Code? CashMargin { get; init; } 
    #else
    public CashMarginOrder1Code? CashMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_jkHD8zAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Commission")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commission16? Commission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commission16? Commission { get; init; } 
    #else
    public Commission16? Commission { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_jkHD9TAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Number Of Days Accrued")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Number? NumberOfDaysAccrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfDaysAccrued { get; init; } 
    #else
    public System.UInt64? NumberOfDaysAccrued { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of days from trade date that the counterparty on the other side of the trade should be "given up" or divulged.
    /// </summary>
    [IsoId("_jkHD_TAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Give Up Number Of Days")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Number? GiveUpNumberOfDays { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? GiveUpNumberOfDays { get; init; } 
    #else
    public System.UInt64? GiveUpNumberOfDays { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the trade is cum interest or ex interest.
    /// </summary>
    [IsoId("_jkHD_zAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interest Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestType2Code? InterestType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestType2Code? InterestType { get; init; } 
    #else
    public InterestType2Code? InterestType { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_jkHEATAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Accrued Interest Percentage")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? AccruedInterestPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AccruedInterestPercentage { get; init; } 
    #else
    public System.Decimal? AccruedInterestPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the regulatory conditions type of the trade.
    /// </summary>
    [IsoId("_jkHEAzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Regulatory Conditions Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeRegulatoryConditions1Code? TradeRegulatoryConditionsType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeRegulatoryConditions1Code? TradeRegulatoryConditionsType { get; init; } 
    #else
    public TradeRegulatoryConditions1Code? TradeRegulatoryConditionsType { get; set; } 
    #endif
    
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds or to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    [IsoId("_jkHEBTAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency To Buy Or Sell")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; } 
    #else
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; set; } 
    #endif
    
    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    [IsoId("_jkHEDTAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Order Originator Eligibility")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Eligibility1Code? OrderOriginatorEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Eligibility1Code? OrderOriginatorEligibility { get; init; } 
    #else
    public Eligibility1Code? OrderOriginatorEligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the resulting position after a trade should be an opening position or closing position. Used for omnibus accounting - where accounts are held on a gross basis instead of being netted together.
    /// </summary>
    [IsoId("_jkHEDzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Position Effect")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionEffect2Code? PositionEffect { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionEffect2Code? PositionEffect { get; init; } 
    #else
    public PositionEffect2Code? PositionEffect { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the derivative product is covered or not by an underlying financial instrument position.
    /// </summary>
    [IsoId("_jkHEFzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Derivative Covered")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DerivativeCovered { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DerivativeCovered { get; init; } 
    #else
    public System.String? DerivativeCovered { get; set; } 
    #endif
    
    /// <summary>
    /// Type of charge/tax basis.
    /// </summary>
    [IsoId("_jkHEHzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Charge Tax Basis Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeTaxBasisType1Choice_? ChargeTaxBasisType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeTaxBasisType1Choice_? ChargeTaxBasisType { get; init; } 
    #else
    public ChargeTaxBasisType1Choice_? ChargeTaxBasisType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of capital gain.
    /// </summary>
    [IsoId("_jkHEITAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Capital Gain Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EUCapitalGainType2Choice_? CapitalGainType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EUCapitalGainType2Choice_? CapitalGainType { get; init; } 
    #else
    public EUCapitalGainType2Choice_? CapitalGainType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the matching status of the trade confirmation.
    /// </summary>
    [IsoId("_jkHEIzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Match Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus8Choice_? MatchStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus8Choice_? MatchStatus { get; init; } 
    #else
    public MatchingStatus8Choice_? MatchStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of pay-in call report.
    /// </summary>
    [IsoId("_jkHEKzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Call In Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CallIn1Code? CallInType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CallIn1Code? CallInType { get; init; } 
    #else
    public CallIn1Code? CallInType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of yield at which the transaction was effected.
    /// </summary>
    [IsoId("_jkHELTAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Yield Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public YieldCalculation2? YieldType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public YieldCalculation2? YieldType { get; init; } 
    #else
    public YieldCalculation2? YieldType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    [IsoId("_jkHELzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reporting")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reporting5Choice_? Reporting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reporting5Choice_? Reporting { get; init; } 
    #else
    public Reporting5Choice_? Reporting { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    [IsoId("_jkHENzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Physical Or Registration Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegistrationParameters3? AdditionalPhysicalOrRegistrationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegistrationParameters3? AdditionalPhysicalOrRegistrationDetails { get; init; } 
    #else
    public RegistrationParameters3? AdditionalPhysicalOrRegistrationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional details of the trade process not included within structured fields of this message.
    /// </summary>
    [IsoId("_jkHEOTAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Trade Instruction Processing Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalTradeInstructionProcessingInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalTradeInstructionProcessingInformation { get; init; } 
    #else
    public System.String? AdditionalTradeInstructionProcessingInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Interest amount that has accrued in between two periods, for example, in between interest payment periods.
    /// </summary>
    [IsoId("_jkHEOzAjEeOUGqA1wUwNLA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Accrued Interest Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection29? AccruedInterestAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
