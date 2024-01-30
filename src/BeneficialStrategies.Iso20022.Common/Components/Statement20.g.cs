﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement20.  ISO2002 ID# _Qp52ptp-Ed-ak6NoX_4Aeg_400350199.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the statement.
/// </summary>
public partial record Statement20
{
    #nullable enable
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    public INumber3Choice? ReportNumber { get; init; } 
    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    public IsoMax35Text? QueryReference { get; init; } 
    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    public IsoMax35Text? StatementIdentification { get; init; } 
    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    public required IDateAndDateTimeChoice StatementDateTime { get; init; } 
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    public required IFrequency4Choice Frequency { get; init; } 
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    public required IUpdateType2Choice UpdateType { get; init; } 
    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    public required IStatementBasis3Choice StatementBasis { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the statement is audited or not.
    /// </summary>
    public required IsoYesNoIndicator AuditedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the statement reports holdings at subsafekeeping account level.
    /// </summary>
    public required IsoYesNoIndicator SubAccountIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the statement contains tax lot details.
    /// </summary>
    public IsoYesNoIndicator? TaxLotIndicator { get; init; } 
    
    #nullable disable
}
