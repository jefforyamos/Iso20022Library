﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement55.  ISO2002 ID# _8VHTX5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the statement.
/// </summary>
public partial record Statement55
{
    #nullable enable
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    public Number3Choice_? ReportNumber { get; init; } 
    /// <summary>
    /// Identification of the statement query message sent to request this statement.
    /// </summary>
    public IsoRestrictedFINXMax16Text? QueryReference { get; init; } 
    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    public IsoRestrictedFINXMax16Text? StatementIdentification { get; init; } 
    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    public Frequency26Choice_? Frequency { get; init; } 
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    public UpdateType16Choice_? UpdateType { get; init; } 
    /// <summary>
    /// Specifies whether the statement is sorted by status or transaction.
    /// </summary>
    public required StatementStructure1Code StatementStructure { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    #nullable disable
}
