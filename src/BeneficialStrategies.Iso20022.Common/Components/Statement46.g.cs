﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement46.  ISO2002 ID# _YOYdpTeQEeWm5uvLSn0jEw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the statement.
/// </summary>
public partial record Statement46
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the portfolio transfer counterpart to unambiguously identify a portfolio transfer notification.
    /// </summary>
    public IsoMax35Text? CounterpartyPortfolioTransferNotificationReference { get; init; } 
    /// <summary>
    /// Sequential number of the report.
    /// </summary>
    public INumber3Choice? ReportNumber { get; init; } 
    /// <summary>
    /// Reference common to all pages of a statement.
    /// </summary>
    public IsoMax35Text? StatementIdentification { get; init; } 
    /// <summary>
    /// Date and time of the statement.
    /// </summary>
    public required IDateAndDateTimeChoice StatementDateTime { get; init; } 
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    public IUpdateType15Choice? UpdateType { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    
    #nullable disable
}
