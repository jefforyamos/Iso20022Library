﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EstimatedFundCashForecast6.  ISO2002 ID# _7dIg4QdlEeSPHJIdUs1USg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash movements from or to a fund as a result of investment funds transactions, eg, subscriptions or redemptions.
/// </summary>
public partial record EstimatedFundCashForecast6
{
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a fund cash forecast within a fund cash forecast report as assigned by the issuer of the report.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Date and, if required, the time, at which the price will be applied.
    /// </summary>
    public required IDateAndDateTimeChoice TradeDateTime { get; init; } 
    /// <summary>
    /// Previous date and time at which the price was applied.
    /// </summary>
    public IDateAndDateTimeChoice? PreviousTradeDateTime { get; init; } 
    /// <summary>
    /// Investment fund class to which the cash flow is related.
    /// </summary>
    public required FinancialInstrument9 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Estimated total value of all the holdings, less the fund's liabilities, attributable to a specific investment fund class.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Previous value of all the holdings, less the fund's liabilities, attributable to a specific investment fund class.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Estimated total number of investment fund class units that have been issued.
    /// </summary>
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; } 
    /// <summary>
    /// Previous value of all the holdings, less the fund's liabilities, attributable to a specific investment fund class.
    /// </summary>
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    public IsoPercentageRate? EstimatedTotalNAVChangeRate { get; init; } 
    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? InvestmentCurrency { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information about the designation of the share class currency, that is, whether it is for onshore or offshore purposes and other information that may be required. This is typically only required for CNY funds.
    /// </summary>
    public CurrencyDesignation1? CurrencyStatus { get; init; } 
    /// <summary>
    /// Indicates whether the estimated net cash flow is exceptional.
    /// </summary>
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; } 
    /// <summary>
    /// Price per unit of the previous trade date.
    /// </summary>
    public UnitPrice19? Price { get; init; } 
    /// <summary>
    /// Foreign exchange rate.
    /// </summary>
    public ForeignExchangeTerms19? ForeignExchangeRate { get; init; } 
    /// <summary>
    /// Estimated net cash flow expressed as a percentage of the previous total NAV for the share class.
    /// </summary>
    public IsoPercentageRate? EstimatedPercentageOfShareClassTotalNAV { get; init; } 
    /// <summary>
    /// Estimated cash movements into the fund as a result of transactions in shares in an investment fund, for example, subscriptions or switch-ins.
    /// </summary>
    public CashInForecast6? EstimatedCashInForecastDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Estimated cash movements out of the fund as a result of transactions in shares in an investment fund, for example, redemptions or switch-outs.
    /// </summary>
    public CashOutForecast6? EstimatedCashOutForecastDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows.
    /// </summary>
    public NetCashForecast4? EstimatedNetCashForecastDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
