﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement6.  ISO2002 ID# _ROkC4tp-Ed-ak6NoX_4Aeg_634334074.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General characteristics related to a statement which reports information for a precise date.
/// </summary>
public partial record Statement6
{
    #nullable enable
    
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    public required IsoMax35Text Reference { get; init; } 
    /// <summary>
    /// Date of the statement.
    /// </summary>
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    /// <summary>
    /// Preparation date of the statement.
    /// </summary>
    public DateAndDateTimeChoice_? CreationDateTime { get; init; } 
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    public required FrequencyCodeAndDSSCode1Choice_ Frequency { get; init; } 
    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    public required StatementUpdateTypeCodeAndDSSCodeChoice_ UpdateType { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    public required StatementBasisCodeAndDSSCodeChoice_ StatementBasis { get; init; } 
    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    public IsoMax5NumericText? ReportNumber { get; init; } 
    /// <summary>
    /// Indicates whether the statement is audited.
    /// </summary>
    public required IsoYesNoIndicator AuditedIndicator { get; init; } 
    
    #nullable disable
}
