﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement72.  ISO2002 ID# _iKq4IbtEEeilsanBGAzy4A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General characteristics related to a statement which reports information.
/// </summary>
public partial record Statement72
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the statement is a balance only notification or if it includes missing instructions only or all instructions.
    /// </summary>
    public required CorporateActionStatementType2Code StatementType { get; init; } 
    /// <summary>
    /// Indicates whether the statement report on account holdings for corporate action events is for single account/multiple events or multiple accounts/single event.
    /// </summary>
    public required CorporateActionStatementReportingType1Code ReportingType { get; init; } 
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    public required IsoMax35Text StatementIdentification { get; init; } 
    /// <summary>
    /// Indicates the period of instruction details within the statement.
    /// </summary>
    public DatePeriod2? InstructionAggregationPeriod { get; init; } 
    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    public IsoMax5NumericText? ReportNumber { get; init; } 
    /// <summary>
    /// Date of the statement.
    /// </summary>
    public required IDateAndDateTime2Choice StatementDateTime { get; init; } 
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    public required IFrequency25Choice Frequency { get; init; } 
    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    public required IUpdateType15Choice UpdateType { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Period during which identification deadline has been set.
    /// </summary>
    public IDateOrDateTimePeriod1Choice? NotificationDeadlinePeriod { get; init; } 
    
    #nullable disable
}
