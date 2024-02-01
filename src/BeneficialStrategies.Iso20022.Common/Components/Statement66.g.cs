﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement66.  ISO2002 ID# _qrED1c3iEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General characteristics related to a statement which reports information.
/// </summary>
public partial record Statement66
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the statement contains missing instructions only or all instructions.
    /// </summary>
    public required CorporateActionStatementType1Code StatementType { get; init; } 
    /// <summary>
    /// Indicates whether the statement report on account holdings for corporate action events is for single account/multiple events or multiple accounts/single event.
    /// </summary>
    public required CorporateActionStatementReportingType1Code ReportingType { get; init; } 
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    public required IsoRestrictedFINXMax16Text StatementIdentification { get; init; } 
    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    public IsoMax5NumericText? ReportNumber { get; init; } 
    /// <summary>
    /// Date of the statement.
    /// </summary>
    public required DateAndDateTime2Choice_ StatementDateTime { get; init; } 
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    public required Frequency26Choice_ Frequency { get; init; } 
    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    public required UpdateType16Choice_ UpdateType { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Period during which identification deadline has been set.
    /// </summary>
    public DateOrDateTimePeriod2Choice_? NotificationDeadlinePeriod { get; init; } 
    
    #nullable disable
}
