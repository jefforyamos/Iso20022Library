﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EstimatedFundCashForecast2.  ISO2002 ID# _VCWdldp-Ed-ak6NoX_4Aeg_-373893977.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash movements from or to a fund as a result of investment funds transactions, eg, subscriptions or redemptions.
/// </summary>
public partial record EstimatedFundCashForecast2
{
    #nullable enable
    
    /// <summary>
    /// Date and, if required, the time, at which the price has been applied.
    /// </summary>
    public required IDateAndDateTimeChoice TradeDateTime { get; init; } 
    /// <summary>
    /// Previous date and time at which a price was applied.
    /// </summary>
    public required IDateAndDateTimeChoice PreviousTradeDateTime { get; init; } 
    /// <summary>
    /// Investment fund class to which a cash flow is related.
    /// </summary>
    public required FinancialInstrument5 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Estimated total value of all the holdings, less the fund's liabilities, attributable to a specific investment fund class.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init; } 
    /// <summary>
    /// Previous estimated value of all the holdings, less the fund's liabilities, attributable to a specific investment fund class.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? PreviousEstimatedTotalNAV { get; init; } 
    /// <summary>
    /// Estimated total number of investment fund class units that have been issued.
    /// </summary>
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; } 
    /// <summary>
    /// Previous estimated value of all the holdings, less the fund's liabilities, attributable to a specific investment fund class.
    /// </summary>
    public FinancialInstrumentQuantity1? PreviousEstimatedTotalUnitsNumber { get; init; } 
    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    public IsoPercentageRate? EstimatedTotalNAVChangeRate { get; init; } 
    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? InvestmentCurrency { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates whether the estimated net cash flow is exceptional.
    /// </summary>
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; } 
    /// <summary>
    /// Information related to the estimated cash movements reported by pre-defined or user defined criteria.
    /// </summary>
    public CashSortingCriterion1? SortingCriteriaDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Net cash movements per financial instrument.
    /// </summary>
    public NetCashForecast1? EstimatedNetCashForecastDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
