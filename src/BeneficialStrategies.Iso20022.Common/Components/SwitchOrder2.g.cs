﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SwitchOrder2.  ISO2002 ID# _VVuFi9p-Ed-ak6NoX_4Aeg_-1360536112.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transfer from one investment fund/fund class to another investment fund or investment fund class by the investor. A switch is composed of one or several subscription legs, and one or several redemption legs.
/// </summary>
public partial record SwitchOrder2
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    public IsoISODateTime? OrderDateTime { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text OrderReference { get; init; } 
    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    public required InvestmentAccount13 InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be redeemed.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? TotalRedemptionAmount { get; init; } 
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be subscribed.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? TotalSubscriptionAmount { get; init; } 
    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    public IsoISODateTime? ExpiryDateTime { get; init; } 
    /// <summary>
    /// Additional amount of money paid by the investor in addition to the switch redemption amount.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? AdditionalCashIn { get; init; } 
    /// <summary>
    /// Amount of money that results from a switch-out, that is not reinvested in another investment fund, and is repaid to the investor.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? ResultingCashOut { get; init; } 
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    public CancellationRight1? CancellationRight { get; init; } 
    /// <summary>
    /// Part of an investment fund switch order that is a redemption.
    /// </summary>
    public SwitchRedemptionLegOrder2? RedemptionLegDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Part of an investment fund switch order that is a subscription.
    /// </summary>
    public SwitchSubscriptionLegOrder2? SubscriptionLegDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Payment transaction resulting from the investment fund order execution.
    /// </summary>
    public PaymentTransaction20? CashSettlementDetails { get; init; } 
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    public ForeignExchangeTerms5? ForeignExchangeDetails { get; init; } 
    
    #nullable disable
}
