﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeDateTimeQueryCriteria2.  ISO2002 ID# _aPgSUdGREeaQk737TH1Fzw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and time query criteria.
/// </summary>
[DataContract]
[XmlType]
public partial record TradeDateTimeQueryCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Indicates the reporting date and full hour that transaction was reported.
    /// </summary>
    [DataMember]
    public DateTimePeriod1? ReportingDateTime { get; init; } 
    /// <summary>
    /// Indicates the date and full hour the trade was executed.
    /// </summary>
    [DataMember]
    public DateTimePeriod1? ExecutionDateTime { get; init; } 
    /// <summary>
    /// Indicates the date when the trade was matured.
    /// </summary>
    [DataMember]
    public DateOrBlankQuery2Choice_? MaturityDate { get; init; } 
    /// <summary>
    /// Indicates the date when the trade was terminated.
    /// </summary>
    [DataMember]
    public DateOrBlankQuery2Choice_? TerminationDate { get; init; } 
    
    #nullable disable
}
