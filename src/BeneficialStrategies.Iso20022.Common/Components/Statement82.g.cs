﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement82.  ISO2002 ID# _s9ln0gVVEeqjd8n6wD9JVw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the statement.
/// </summary>
public partial record Statement82
{
    #nullable enable
    
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    public Number3Choice_? ReportNumber { get; init; } 
    /// <summary>
    /// Identification of the SecuritiesStatementQuery message sent to request this statement.
    /// </summary>
    public IsoRestrictedFINXMax16Text? QueryReference { get; init; } 
    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    public IsoRestrictedFINXMax16Text? StatementIdentification { get; init; } 
    /// <summary>
    /// Period for the statement.
    /// </summary>
    public required Period7Choice_ StatementPeriod { get; init; } 
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    public Frequency26Choice_? Frequency { get; init; } 
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    public UpdateType16Choice_? UpdateType { get; init; } 
    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    public required StatementBasis12Choice_ StatementBasis { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the statement reports holdings at subsafekeeping account level.
    /// </summary>
    public required IsoYesNoIndicator SubAccountIndicator { get; init; } 
    
    #nullable disable
}
