﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeQueryCriteria9.  ISO2002 ID# _QG7ipa5pEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Query criteria on a trade transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record TradeQueryCriteria9
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the response must include all reports submitted for a trade (true) or only the current state of the trade (false).
    /// Usage:
    /// If false is selected, the reporting timestamp element must be absent.
    /// </summary>
    [DataMember]
    public required IsoTrueFalseIndicator TradeLifeCycleHistory { get; init; } 
    /// <summary>
    /// Indicates whether the response must include all trades  (false) or only the outstanding trades (true).
    /// </summary>
    [DataMember]
    public required IsoTrueFalseIndicator OutstandingTradeIndicator { get; init; } 
    /// <summary>
    /// Query criteria related to counterparties.
    /// </summary>
    [DataMember]
    public TradePartyQueryCriteria5? TradePartyCriteria { get; init; } 
    /// <summary>
    /// Query criteria related to transaction types.
    /// </summary>
    [DataMember]
    public TradeTypeQueryCriteria1? TradeTypeCriteria { get; init; } 
    /// <summary>
    /// Query criteria related to time values.
    /// </summary>
    [DataMember]
    public TradeDateTimeQueryCriteria2? TimeCriteria { get; init; } 
    /// <summary>
    /// Query criteria related to other fields.
    /// </summary>
    [DataMember]
    public TradeAdditionalQueryCriteria7? OtherCriteria { get; init; } 
    
    #nullable disable
}
