﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RedemptionOrder6.  ISO2002 ID# _SDKvrdp-Ed-ak6NoX_4Aeg_-97453543.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction from an investor to sell investment fund units back to the fund.
/// </summary>
public partial record RedemptionOrder6
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
    // public IReadOnlyCollection<FundOrderType2> OrderType { get; init; }
    /// <summary>
    /// Investment fund class related to an order.
    /// </summary>
    public required FinancialInstrument10 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Subdivision of an account used to segregate specific holdings.
    /// </summary>
    public SubAccount1? SubAccountForHolding { get; init; } 
    /// <summary>
    /// Quantity of investment fund units redeemed.
    /// </summary>
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be sold, before deduction of charges, commissions, and taxes.|[Quantity * Price].
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount GrossAmount { get; init; } 
    /// <summary>
    /// Amount of money to be received following redemption after deduction of charges, commissions and taxes and used to derive the quantity of investment fund units to be sold.|[(Quantity * Price) - (Charges + Commissions +Taxes)].
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount NetAmount { get; init; } 
    /// <summary>
    /// Portion of the investor's holdings, in a specific investment fund/ fund class, that is redeemed.
    /// </summary>
    public required IsoPercentageRate HoldingsRedemptionRate { get; init; } 
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
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; } 
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
    public FundSettlementParameters3? SettlementAndCustodyDetails { get; init; } 
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public required IsoYesNoIndicator PhysicalDeliveryIndicator { get; init; } 
    /// <summary>
    /// Information related to physical delivery of the securities.
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
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    public PaymentTransaction21? CashSettlementDetails { get; init; } 
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    /// <summary>
    /// Breakdown of the net amount per type of order.
    /// </summary>
    // public IReadOnlyCollection<InvestmentFundsOrderBreakdown1> StaffClientBreakdown { get; init; }
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
    // public IReadOnlyCollection<Intermediary8> RelatedPartyDetails { get; init; }
    /// <summary>
    /// Part of an investor's subscription amount that is held by the fund in order to pay incentive / performance fees at the end of the fiscal year.
    /// </summary>
    public Equalisation1? Equalisation { get; init; } 
    
    #nullable disable
}
