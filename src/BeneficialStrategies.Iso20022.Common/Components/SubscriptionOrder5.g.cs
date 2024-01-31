﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubscriptionOrder5.  ISO2002 ID# _SH767Np-Ed-ak6NoX_4Aeg_-2055653957.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order to invest the investor's principal in an investment fund.
/// </summary>
public partial record SubscriptionOrder5
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text OrderReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    public IReadOnlyCollection<FundOrderType2> OrderType { get; init; } = [];
    /// <summary>
    /// Additional information about the investor.
    /// </summary>
    public IndividualPerson9? BeneficiaryDetails { get; init; } 
    /// <summary>
    /// Quantity of investment fund units to be subscribed.
    /// </summary>
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    /// <summary>
    /// Amount of money to be invested in a specific financial instrument by an investor before deduction of charges, commissions and taxes and used to determine the quantity of investment fund units to be subscribed.|[(Quantity * Price) + (Charges + Commissions +Taxes)].
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount GrossAmount { get; init; } 
    /// <summary>
    /// Amount of money remaining after deduction of charges, commissions and taxes and used to determine the quantity of investment fund units to be subscribed.|[Quantity * Price].
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount NetAmount { get; init; } 
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    public RoundingDirection2Code? Rounding { get; init; } 
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    public IsoISODate? CashSettlementDate { get; init; } 
    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    public DeliveryReceiptType2Code? SettlementMethod { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Account impacted by an investment fund order.
    /// </summary>
    public required InvestmentAccount21 InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer's actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer. A letter of intent program is mainly used in the US market.
    /// </summary>
    public IsoMax35Text? LetterIntentReference { get; init; } 
    /// <summary>
    /// Reference of an accumulation right program, in which sales commissions are based on a customer's present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    public IsoMax35Text? AccumulationRightReference { get; init; } 
    /// <summary>
    /// Charge for the placement of an order.
    /// </summary>
    public Charge17? ChargeDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    public Commission10? CommissionDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Tax applicable to an investment fund order.
    /// </summary>
    public Tax16? TaxDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Parameters used to execute the settlement of an investment fund order.
    /// </summary>
    public FundSettlementParameters4? SettlementAndCustodyDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    /// <summary>
    /// Information related to physical delivery of the securities.
    /// </summary>
    public NameAndAddress4? PhysicalDeliveryDetails { get; init; } 
    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    public PaymentTransaction23? CashSettlementDetails { get; init; } 
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    public IReadOnlyCollection<InvestmentFundsOrderBreakdown1> StaffClientBreakdown { get; init; } = [];
    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    public FinancialAdvice1Code? FinancialAdvice { get; init; } 
    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; } 
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    public IReadOnlyCollection<Intermediary8> RelatedPartyDetails { get; init; } = [];
    /// <summary>
    /// Part of an investor's subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    public Equalisation1? Equalisation { get; init; } 
    
    #nullable disable
}
