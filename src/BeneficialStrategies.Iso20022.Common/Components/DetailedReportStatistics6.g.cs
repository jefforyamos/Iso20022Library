﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedReportStatistics6.  ISO2002 ID# _zQlJ8U2UEe2bQ-Ksk8mwQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed statistics on reports.
/// </summary>
public partial record DetailedReportStatistics6
{
    #nullable enable
    
    /// <summary>
    /// Total number of reports sent or received.
    /// </summary>
    public required IsoMax15NumericText TotalNumberOfReports { get; init; } 
    /// <summary>
    /// Total number of reports accepted.
    /// </summary>
    public required IsoMax15NumericText TotalNumberOfReportsAccepted { get; init; } 
    /// <summary>
    /// Total number of reports rejected.
    /// </summary>
    public required IsoMax15NumericText TotalNumberOfReportsRejected { get; init; } 
    /// <summary>
    /// Number of reports rejected per error code.
    /// </summary>
    public NumberOfTransactionsPerValidationRule6[] NumberOfReportsRejectedPerError { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
