﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AdHocQuery.  ISO2002 ID# _QH0wcYeAEei-Poi-FosJdw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery4Choice;

/// <summary>
/// Query criteria specifically applied to ad-hoc queries.
/// </summary>
public partial record AdHocQuery : ITradeReportQuery4Choice
{
    #nullable enable
    /// <summary>
    /// Field to define whether the query response file will include all reports submitted for a trade [true]or only the current state of the trade [false].
    /// If false is selected, the reporting timestamp field cannot be used.
    /// </summary>
    public required IsoTrueFalseIndicator TradeLifeCycleHistory { get; init; } 
    /// <summary>
    /// Field to define whether if the query response file will include all trades or only the outstanding trades.
    /// </summary>
    public required IsoTrueFalseIndicator OutstandingTradeIndicator { get; init; } 
    /// <summary>
    /// Query criteria related to counterparties.
    /// </summary>
    public TradePartyQueryCriteria3? TradePartyCriteria { get; init; } 
    /// <summary>
    /// Indicates the query criteria related to financial instruments.
    /// </summary>
    public TradeSecurityIdentificationQueryCriteria2? FinancialInstrumentCriteria { get; init; } 
    /// <summary>
    /// Query criteria related to time values.
    /// </summary>
    public TradeDateTimeQueryCriteria2? TimeCriteria { get; init; } 
    /// <summary>
    /// Query criteria related to other fields.
    /// </summary>
    public TradeAdditionalQueryCriteria3? OtherCriteria { get; init; } 
    #nullable disable
}
