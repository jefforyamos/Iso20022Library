﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RedemptionExecution15.  ISO2002 ID# _GjGCBTbtEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a redemption order.
/// </summary>
public partial record RedemptionExecution15
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text OrderReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    public required IsoMax35Text DealReference { get; init; } 
    /// <summary>
    /// Category of the investment fund order.
    /// </summary>
    // public IReadOnlyCollection<IFundOrderType4Choice> OrderType { get; init; }
    /// <summary>
    /// Investment fund class to which the investment fund order execution is related.
    /// </summary>
    public required FinancialInstrument57 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Subdivision of the account used to segregate specific holdings.
    /// </summary>
    public SubAccount6? SubAccountForHolding { get; init; } 
    /// <summary>
    /// Number of investment funds units redeemed.
    /// </summary>
    public required IsoDecimalNumber UnitsNumber { get; init; } 
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    public RoundingDirection2Code? Rounding { get; init; } 
    /// <summary>
    /// Amount of money paid to the investor when redeeming fund units. 
    /// Net amount = (Quantity * Price) – (Fees + Taxes).
    /// </summary>
    public IsoActiveCurrencyAndAmount? NetAmount { get; init; } 
    /// <summary>
    /// Amount of money redeemed from the fund. 
    /// Gross Amount = Quantity * Price.
    /// </summary>
    public IsoActiveCurrencyAndAmount? GrossAmount { get; init; } 
    /// <summary>
    /// Portion of the investor's holdings redeemed.
    /// </summary>
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; } 
    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    public required IDateAndDateTimeChoice TradeDateTime { get; init; } 
    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    public required UnitPrice22 DealingPriceDetails { get; init; } 
    /// <summary>
    /// Other quoted price than the one at which the order was executed.
    /// </summary>
    // public IReadOnlyCollection<UnitPrice22> InformativePriceDetails { get; init; }
    /// <summary>
    /// Total amount of money paid/to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    public required IsoActiveCurrencyAndAmount SettlementAmount { get; init; } 
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    public IsoISODate? CashSettlementDate { get; init; } 
    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    public DeliveryReceiptType2Code? SettlementMethod { get; init; } 
    /// <summary>
    /// Indicates whether the order has been partially executed, that is, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; } 
    /// <summary>
    /// Specifies that the execution was subject to best execution rules as defined by MiFID.
    /// </summary>
    public BestExecution1Code? BestExecution { get; init; } 
    /// <summary>
    /// Indicates whether the dividend is included, that is, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    public required IsoYesNoIndicator CumDividendIndicator { get; init; } 
    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    public IProfitAndLoss2Choice? InterimProfitAmount { get; init; } 
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// How the exchange rate is expressed determines which currency is the Unit Currency and Quoted Currency. If the amounts concerned are EUR 1000 and USD 1300, the exchange rate may be expressed as per either of the following examples:
    /// EXAMPLE 1 
    /// UnitCurrency EUR
    /// QuotedCurrency USD
    /// ExchangeRate 1.300
    /// EXAMPLE 2
    /// UnitCurrency USD
    /// QuotedCurrency EUR
    /// ExchangeRate 0.769.
    /// </summary>
    public ForeignExchangeTerms33? ForeignExchangeDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; } 
    /// <summary>
    /// Fees (charges/commission) and taxes that are taken into consideration for the transaction, so that the total difference between the net amount and gross amount is known, without taking into account equalisation.
    /// </summary>
    public TotalFeesAndTaxes40? TransactionOverhead { get; init; } 
    /// <summary>
    /// Additional information about tax that does not have an impact on the transaction overhead.
    /// </summary>
    public InformativeTax1? InformativeTaxDetails { get; init; } 
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    public FundSettlementParameters11? SettlementAndCustodyDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    public DeliveryParameters3? PhysicalDeliveryDetails { get; init; } 
    /// <summary>
    /// Currency requested for settlement of cash proceeds.
    /// </summary>
    public ActiveCurrencyCode? RequestedSettlementCurrency { get; init; } 
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; } 
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    public PaymentTransaction72? CashSettlementDetails { get; init; } 
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    /// <summary>
    /// Percentage of units partially settled.
    /// </summary>
    public IsoPercentageRate? PartialSettlementOfUnits { get; init; } 
    /// <summary>
    /// Percentage of cash partially settled.
    /// </summary>
    public IsoPercentageRate? PartialSettlementOfCash { get; init; } 
    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    // public IReadOnlyCollection<InvestmentFundsOrderBreakdown2> StaffClientBreakdown { get; init; }
    /// <summary>
    /// Amount retained by the fund and paid out later at a time decided by the fund.
    /// </summary>
    public IsoActiveCurrencyAndAmount? PartialRedemptionWithholdingAmount { get; init; } 
    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    public FinancialAdvice1Code? FinancialAdvice { get; init; } 
    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; } 
    /// <summary>
    /// Specifies whether the order execution confirmation is late.
    /// </summary>
    public LateReport1Code? LateReport { get; init; } 
    /// <summary>
    /// Party related to the transaction.
    /// </summary>
    // public IReadOnlyCollection<Intermediary39> RelatedPartyDetails { get; init; }
    /// <summary>
    /// Part of an investor's subscription amount that was held by the fund in order to pay incentive/performance fees at the end of the fiscal year, and is returned due to the redemption.
    /// </summary>
    public Equalisation1? Equalisation { get; init; } 
    /// <summary>
    /// Assessment of the customer’s behaviour at the time of the account opening application.
    /// </summary>
    public ICustomerConductClassification1Choice? CustomerConductClassification { get; init; } 
    /// <summary>
    /// Means by which the investor or account owner submits the open account form.
    /// </summary>
    public ITransactionChannelType1Choice? TransactionChannelType { get; init; } 
    /// <summary>
    /// Type of signature.
    /// </summary>
    public ISignatureType1Choice? SignatureType { get; init; } 
    /// <summary>
    /// Information about a non-standard order.
    /// </summary>
    public OrderWaiver1? OrderWaiverDetails { get; init; } 
    /// <summary>
    /// Information about gating and hold back of redemption proceeds.
    /// </summary>
    public HoldBackInformation2? GatingOrHoldBackDetails { get; init; } 
    
    #nullable disable
}
