﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashInForecast6.  ISO2002 ID# _ii-7AQdmEeSPHJIdUs1USg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash movements into a fund as a result of investment funds transactions, eg, subscriptions or switch-in.
/// </summary>
public partial record CashInForecast6
{
    #nullable enable
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    public required IsoISODate CashSettlementDate { get; init; } 
    /// <summary>
    /// Sub-total amount of the cash flow in, expressed as an amount of money.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? SubTotalAmount { get; init; } 
    /// <summary>
    /// Sub-total amount of the cash flow in, expressed as a number of units.
    /// </summary>
    public FinancialInstrumentQuantity1? SubTotalUnitsNumber { get; init; } 
    /// <summary>
    /// Indicates whether the cash flow in is exceptional.
    /// </summary>
    public IsoYesNoIndicator? ExceptionalCashFlowIndicator { get; init; } 
    /// <summary>
    /// Additional balances for cash amounts and number of units. 
    /// In an estimated report, the total cash derived from orders placed as a number of units is an estimated cash amount and the total number of units derived from orders placed as a cash amount is an estimated number of units.
    /// </summary>
    public FundBalance1? AdditionalBalance { get; init; } 
    
    #nullable disable
}
