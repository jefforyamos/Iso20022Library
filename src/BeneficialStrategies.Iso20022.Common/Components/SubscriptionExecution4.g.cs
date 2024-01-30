﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubscriptionExecution4.  ISO2002 ID# _VU0tpNp-Ed-ak6NoX_4Aeg_553787060.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Execution of a subscription order.
/// </summary>
public partial record SubscriptionExecution4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text OrderReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    public required IsoMax35Text DealReference { get; init; } 
    /// <summary>
    /// Specifies the category of the investment fund order.
    /// </summary>
    public FundOrderType1? OrderType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Investment fund class to which an investment fund order execution is related.
    /// </summary>
    public required FinancialInstrument6 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Number of investment fund units subscribed.
    /// </summary>
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; } 
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    public RoundingDirection2Code? Rounding { get; init; } 
    /// <summary>
    /// Net amount of money invested in a specific financial instrument by an investor, expressed in the currency requested by the investor.
    /// </summary>
    public required IsoActiveCurrencyAndAmount NetAmount { get; init; } 
    /// <summary>
    /// Amount of money invested in a specific financial instrument by an investor, including all charges, commissions, and tax, expressed in the currency requested by the investor.
    /// </summary>
    public IsoActiveCurrencyAndAmount? GrossAmount { get; init; } 
    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    public required IDateAndDateTimeChoice TradeDateTime { get; init; } 
    /// <summary>
    /// Price at which the order was executed.
    /// </summary>
    public required UnitPrice5 PriceDetails { get; init; } 
    /// <summary>
    /// Indicates whether the order has been partially executed, ie, the confirmed quantity does not match the ordered quantity for a given financial instrument.
    /// </summary>
    public required IsoYesNoIndicator PartiallyExecutedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the dividend is included, ie, cum-dividend, in the executed price. When the dividend is not included, the price will be ex-dividend.
    /// </summary>
    public required IsoYesNoIndicator CumDividendIndicator { get; init; } 
    /// <summary>
    /// Part of the price deemed as accrued income or profit rather than capital. The interim profit amount is used for tax purposes.
    /// </summary>
    public IProfitAndLoss1Choice? InterimProfitAmount { get; init; } 
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    public ForeignExchangeTerms4? ForeignExchangeDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference1Code? IncomePreference { get; init; } 
    /// <summary>
    /// Reference of a letter of intent program, in which sales commissions are reduced based on the aggregate of a customer's actual purchase and anticipated purchases, over a specific period of time, and as agreed by the customer. A letter of intent program is mainly used in the US market.
    /// </summary>
    public IsoMax35Text? LetterIntentReference { get; init; } 
    /// <summary>
    /// Reference of an accumulation right program, in which sales commissions are based on a customer's present purchases of shares and the aggregate quantity previously purchased by the customer. An accumulation rights program is mainly used in the US market.
    /// </summary>
    public IsoMax35Text? AccumulationRightReference { get; init; } 
    /// <summary>
    /// Amount of money associated with a service.
    /// </summary>
    public TotalCharges2? ChargeGeneralDetails { get; init; } 
    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    public TotalCommissions2? CommissionGeneralDetails { get; init; } 
    /// <summary>
    /// Tax related to an investment fund order.
    /// </summary>
    public TotalTaxes2? TaxGeneralDetails { get; init; } 
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
    public CurrencyCode? RequestedSettlementCurrency { get; init; } 
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    public CurrencyCode? RequestedNAVCurrency { get; init; } 
    /// <summary>
    /// Return of cash that has been overpaid for a subscription.
    /// </summary>
    public IsoActiveCurrencyAndAmount? Refund { get; init; } 
    /// <summary>
    /// Interest received when a subscription amount is paid in advance and then invested by the fund.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SubscriptionInterest { get; init; } 
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    public PaymentTransaction13? CashSettlementDetails { get; init; } 
    
    #nullable disable
}
