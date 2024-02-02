﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubscriptionOrder15.  ISO2002 ID# _yCJGbzbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order to invest the investor's principal in an investment fund.
/// </summary>
[DataContract]
[XmlType]
public partial record SubscriptionOrder15
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [DataMember]
    public required IsoMax35Text OrderReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Category of the investment fund order.
    /// </summary>
    [DataMember]
    public ValueList<FundOrderType4Choice_> OrderType { get; init; } = [];
    /// <summary>
    /// Amount of money or the number of units for the subscription order.
    /// </summary>
    [DataMember]
    public required FinancialInstrumentQuantity27Choice_ AmountOrUnits { get; init; } 
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [DataMember]
    public RoundingDirection2Code? Rounding { get; init; } 
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [DataMember]
    public IsoActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [DataMember]
    public IsoISODate? CashSettlementDate { get; init; } 
    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [DataMember]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [DataMember]
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Account impacted by the investment fund order.
    /// </summary>
    [DataMember]
    public required InvestmentAccount58 InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    [DataMember]
    public ValueList<IndividualPerson31> BeneficiaryDetails { get; init; } = []; // Warning: Don't know multiplicity.
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
    [DataMember]
    public ForeignExchangeTerms32? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer's actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer. A letter of intent program is mainly used in the US market.
    /// </summary>
    [DataMember]
    public IsoMax35Text? LetterIntentReference { get; init; } 
    /// <summary>
    /// Reference of an accumulation right program, in which sales commissions are based on a customer's present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    [DataMember]
    public IsoMax35Text? AccumulationRightReference { get; init; } 
    /// <summary>
    /// Fees (charges/commission) and tax to be applied to the net amount.
    /// </summary>
    [DataMember]
    public FeeAndTax1? TransactionOverhead { get; init; } 
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    [DataMember]
    public FundSettlementParameters11? SettlementAndCustodyDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    [DataMember]
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    /// <summary>
    /// Information related to the physical delivery of the securities.
    /// </summary>
    [DataMember]
    public NameAndAddress4? PhysicalDeliveryDetails { get; init; } 
    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [DataMember]
    public PaymentTransaction70? CashSettlementDetails { get; init; } 
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [DataMember]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    [DataMember]
    public ValueList<InvestmentFundsOrderBreakdown2> StaffClientBreakdown { get; init; } = [];
    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [DataMember]
    public FinancialAdvice1Code? FinancialAdvice { get; init; } 
    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [DataMember]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; } 
    /// <summary>
    /// Party related to the transaction.
    /// </summary>
    [DataMember]
    public ValueList<Intermediary40> RelatedPartyDetails { get; init; } = [];
    /// <summary>
    /// Part of an investor's subscription amount that is held by the fund in order to pay incentive/performance fees at the end of the fiscal year.
    /// </summary>
    [DataMember]
    public Equalisation1? Equalisation { get; init; } 
    /// <summary>
    /// Source of cash used for the settlement of the subscription.
    /// </summary>
    [DataMember]
    public ValueList<SourceOfCash1Choice_> SourceOfCash { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Assessment of the customer’s behaviour at the time of the account opening application.
    /// </summary>
    [DataMember]
    public CustomerConductClassification1Choice_? CustomerConductClassification { get; init; } 
    /// <summary>
    /// Means by which the investor or account owner submits the open account form.
    /// </summary>
    [DataMember]
    public TransactionChannelType1Choice_? TransactionChannelType { get; init; } 
    /// <summary>
    /// Type of signature.
    /// </summary>
    [DataMember]
    public SignatureType1Choice_? SignatureType { get; init; } 
    /// <summary>
    /// Information about a non-standard order.
    /// </summary>
    [DataMember]
    public OrderWaiver1? OrderWaiverDetails { get; init; } 
    
    #nullable disable
}
