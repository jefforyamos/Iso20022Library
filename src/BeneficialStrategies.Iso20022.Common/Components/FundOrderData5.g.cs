﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FundOrderData5.  ISO2002 ID# _JSDipTbtEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extract of trade data for an investment fund order.
/// </summary>
public partial record FundOrderData5
{
    #nullable enable
    
    /// <summary>
    /// Account information of the individual order instruction for which the status is given.
    /// </summary>
    public InvestmentAccount58? InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Financial instrument information of the individual order instruction for which the status is given.
    /// </summary>
    public FinancialInstrument57? FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Number of investment fund units subscribed or redeemed.
    /// </summary>
    public IsoDecimalNumber? UnitsNumber { get; init; } 
    /// <summary>
    /// When the status message is used for a subscription, this is the amount of money to be invested in the fund. 
    /// Net Amount = Quantity * Price.
    /// When the status message is used for a redemption, this is the amount of money to be received following redemption of fund units. 
    /// Net Amount = (Quantity * Price) - (Fees + Taxes).
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? NetAmount { get; init; } 
    /// <summary>
    /// When the status message is used for a subscription, this is the amount of money to be paid by the investor when subscribing to fund units. 
    /// Gross amount = (Quantity * Price) + (Fees + Taxes). 
    /// When the status message is used for a redemption, this is the amount of money to be redeemed from the fund. 
    /// Gross Amount = Quantity * Price.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? GrossAmount { get; init; } 
    /// <summary>
    /// Portion of the investor's holdings, in a specific investment fund/fund class, that is redeemed.
    /// </summary>
    public IsoPercentageRate? HoldingsRedemptionRate { get; init; } 
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    /// <summary>
    /// Currency from which the quoted currency is converted in an exchange rate calculation.
    /// 1 x <UnitCcy> = <XchgRate> x <QtdCcy>.
    /// </summary>
    public ActiveCurrencyCode? UnitCurrency { get; init; } 
    /// <summary>
    /// Currency into which the unit currency is converted in an exchange rate calculation.
    /// 1 x <UnitCcy> = <XchgRate> x <QtdCcy>.
    /// </summary>
    public ActiveCurrencyCode? QuotedCurrency { get; init; } 
    
    #nullable disable
}
