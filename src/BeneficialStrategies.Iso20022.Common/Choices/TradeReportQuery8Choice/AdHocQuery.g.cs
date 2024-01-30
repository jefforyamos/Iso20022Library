﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AdHocQuery.  ISO2002 ID# _4ae5Uf_lEemm3skPVSMJQg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery8Choice;

/// <summary>
/// Query criteria specifically applied to ad-hoc queries.
/// </summary>
public partial record AdHocQuery : ITradeReportQuery8Choice
{
    #nullable enable
    /// <summary>
    /// Indicates whether the response must include all reports submitted for a trade (true) or only the current state of the trade (false).
    /// Usage:
    /// If false is selected, the reporting timestamp element must be absent.
    /// </summary>
    public required IsoTrueFalseIndicator TradeLifeCycleHistory { get; init; } 
    /// <summary>
    /// Indicates whether the response must include all trades  (false) or only the outstanding trades (true).
    /// </summary>
    public required IsoTrueFalseIndicator OutstandingTradeIndicator { get; init; } 
    /// <summary>
    /// Query criteria related to counterparties.
    /// </summary>
    public TradePartyQueryCriteria5? TradePartyCriteria { get; init; } 
    /// <summary>
    /// Query criteria related to transaction types.
    /// </summary>
    public TradeTypeQueryCriteria1? TradeTypeCriteria { get; init; } 
    /// <summary>
    /// Query criteria related to time values.
    /// </summary>
    public TradeDateTimeQueryCriteria2? TimeCriteria { get; init; } 
    /// <summary>
    /// Query criteria related to other fields.
    /// </summary>
    public TradeAdditionalQueryCriteria6? OtherCriteria { get; init; } 
    #nullable disable
}
