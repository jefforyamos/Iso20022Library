﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementFailsReportHeader2.  ISO2002 ID# _h8xRgR2yEeqF2P5v-Rtejg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies parameters of the report.
/// </summary>
public partial record SettlementFailsReportHeader2
{
    #nullable enable
    
    /// <summary>
    /// Provides the reporting timestamp, when the report was submitted from the CSD to the Competent Authority.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Period covered by the report.
    /// </summary>
    public required DatePeriod2 ReportingPeriod { get; init; } 
    /// <summary>
    /// Specifies the currency used to report the aggregated values of the transactions.
    /// Usage: this is the currency in which the values have to be reported, when no explicit currency is provided.
    /// </summary>
    public required ActiveCurrencyCode Currency { get; init; } 
    /// <summary>
    /// Provides the status of the report.
    /// </summary>
    public required TransactionOperationType4Code ReportStatus { get; init; } 
    /// <summary>
    /// Specifies the securities settlement system used in a settlement process.
    /// </summary>
    public required SecuritiesSettlementSystemIdentification2 SecuritiesSettlementSystem { get; init; } 
    
    #nullable disable
}
