﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EstimatedFundCashForecast4.  ISO2002 ID# _Sj8hedp-Ed-ak6NoX_4Aeg_-271542988.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash movements from or to a fund as a result of investment funds transactions, eg, subscriptions or redemptions.
/// </summary>
[DataContract]
[XmlType]
public partial record EstimatedFundCashForecast4
{
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a fund cash forecast within a fund cash forecast report as assigned by the issuer of the report.
    /// </summary>
    [DataMember]
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Date and, if required, the time, at which the price has been applied.
    /// </summary>
    [DataMember]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    /// <summary>
    /// Previous date and time at which a price was applied.
    /// </summary>
    [DataMember]
    public required DateAndDateTimeChoice_ PreviousTradeDateTime { get; init; } 
    /// <summary>
    /// Investment fund class to which the cash flow is related.
    /// </summary>
    [DataMember]
    public required FinancialInstrument9 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Estimated total value of all the holdings, less the fund's liabilities, attributable to a specific investment fund class.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init; } 
    /// <summary>
    /// Previous value of all the holdings, less the fund's liabilities, attributable to a specific investment fund class.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; } 
    /// <summary>
    /// Estimated total number of investment fund class units that have been issued.
    /// </summary>
    [DataMember]
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; } 
    /// <summary>
    /// Previous value of all the holdings, less the fund's liabilities, attributable to a specific investment fund class.
    /// </summary>
    [DataMember]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    /// <summary>
    /// Estimated cash flow by party.
    /// </summary>
    [DataMember]
    public ValueList<BreakdownByParty1> BreakdownByParty { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Estimated cash flow by country.
    /// </summary>
    [DataMember]
    public ValueList<BreakdownByCountry1> BreakdownByCountry { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Estimated cash flow by currency.
    /// </summary>
    [DataMember]
    public ValueList<BreakdownByCurrency1> BreakdownByCurrency { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Estimated cash flow by a user defined parameter/s.
    /// </summary>
    [DataMember]
    public ValueList<BreakdownByUserDefinedParameter1> BreakdownByUserDefinedParameter { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Rate of change of the net asset value.
    /// </summary>
    [DataMember]
    public IsoPercentageRate? EstimatedTotalNAVChangeRate { get; init; } 
    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [DataMember]
    public ValueList<ActiveOrHistoricCurrencyCode> InvestmentCurrency { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates whether the estimated net cash flow is exceptional.
    /// </summary>
    [DataMember]
    public required IsoYesNoIndicator ExceptionalNetCashFlowIndicator { get; init; } 
    /// <summary>
    /// Estimated net cash movements per financial instrument.
    /// </summary>
    [DataMember]
    public ValueList<NetCashForecast2> EstimatedNetCashForecastDetails { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
