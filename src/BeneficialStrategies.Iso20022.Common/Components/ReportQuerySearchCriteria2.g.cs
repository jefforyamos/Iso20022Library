﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportQuerySearchCriteria2.  ISO2002 ID# _3b6DFZb6Eee4htziCyV8eA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a report.
/// </summary>
[DataContract]
[XmlType]
public partial record ReportQuerySearchCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [DataMember]
    public ValueList<AccountIdentificationSearchCriteria2Choice_> AccountIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Numerical representation of the net increases and decreases in an account at a specific point in time. A cash balance is calculated from a sum of cash credits minus a sum of cash debits.
    /// </summary>
    [DataMember]
    public ValueList<CashBalance12> Balance { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Values of possible reports.
    /// </summary>
    [DataMember]
    public IsoMax4AlphaNumericText? ReportName { get; init; } 
    /// <summary>
    /// Specifies the query message name identifier to which the message refers.
    /// </summary>
    [DataMember]
    public IsoMax35Text? MessageNameIdentification { get; init; } 
    /// <summary>
    /// Report owning party.
    /// </summary>
    [DataMember]
    public required PartyIdentification136 PartyIdentification { get; init; } 
    /// <summary>
    /// Responsible Party of the report owning party.
    /// </summary>
    [DataMember]
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; } 
    /// <summary>
    /// Date and time when the report was created.
    /// </summary>
    [DataMember]
    public DatePeriodSearch1Choice_? DateSearch { get; init; } 
    /// <summary>
    /// Time when the (business) event, which triggered the report, was scheduled.
    /// </summary>
    [DataMember]
    public DateTimePeriod1Choice_? ScheduledTime { get; init; } 
    /// <summary>
    /// Execution type is executed based on an event driven trigger.
    /// </summary>
    [DataMember]
    public EventType1Choice_? Event { get; init; } 
    
    #nullable disable
}
