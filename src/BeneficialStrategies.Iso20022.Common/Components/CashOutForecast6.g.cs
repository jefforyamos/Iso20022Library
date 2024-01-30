﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashOutForecast6.  ISO2002 ID# _Eh20QQdnEeSPHJIdUs1USg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash movements out of a fund as a result of investment funds transactions, eg, redemptions or switch-out.
/// </summary>
public partial record CashOutForecast6
{
    #nullable enable
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    public required IsoISODate CashSettlementDate { get; init; } 
    /// <summary>
    /// Sub-total amount of the cash flow out, expressed as an amount of money.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? SubTotalAmount { get; init; } 
    /// <summary>
    /// Sub-total amount of the cash flow out, expressed as a number of units.
    /// </summary>
    public FinancialInstrumentQuantity1? SubTotalUnitsNumber { get; init; } 
    /// <summary>
    /// Indicates whether the cash flow out is exceptional.
    /// </summary>
    public IsoYesNoIndicator? ExceptionalCashFlowIndicator { get; init; } 
    /// <summary>
    /// Additional balances for cash amounts and number of units. 
    /// In an estimated report, the total cash derived from orders placed as a number of units is an estimated cash amount and the total number of units derived from orders placed as a cash amount is an estimated number of units.
    /// </summary>
    public FundBalance1? AdditionalBalance { get; init; } 
    
    #nullable disable
}
