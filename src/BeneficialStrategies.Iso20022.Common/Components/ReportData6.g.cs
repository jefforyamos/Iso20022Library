﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportData6.  ISO2002 ID# _fuq9cMlNEeuJ35KoBRZFOg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the attributes of a report and its content.
/// </summary>
public partial record ReportData6
{
    #nullable enable
    
    /// <summary>
    /// Name of the report.
    /// </summary>
    public IsoMax140Text? Name { get; init; } 
    /// <summary>
    /// Report identification.
    /// </summary>
    public IsoMax140Text? Identification { get; init; } 
    /// <summary>
    /// Additional specific information to ID (Country, Service, etc.)
    /// </summary>
    public IsoMax70Text? Qualifier { get; init; } 
    /// <summary>
    /// Date of the report.
    /// </summary>
    public IsoISODate? Date { get; init; } 
    /// <summary>
    /// Time of the report.
    /// </summary>
    public IsoISOTime? Time { get; init; } 
    /// <summary>
    /// Contains the specific instance of the report (e.g., sequence “2” of the report within a specific time frame).
    /// </summary>
    public IsoMax5NumericText? Sequence { get; init; } 
    /// <summary>
    /// Contains the expected total number of occurrences of the report within a specific time frame.
    /// </summary>
    public IsoMax5NumericText? TotalOccurrences { get; init; } 
    /// <summary>
    /// Report frequency.
    /// </summary>
    public Frequency17Code? Frequency { get; init; } 
    /// <summary>
    /// Identifies that is a corrected version of a report that was previously sent.
    /// </summary>
    public CorrectionIdentification1? Correction { get; init; } 
    /// <summary>
    /// Indicates that report is not complete.
    /// </summary>
    public IsoTrueFalseIndicator? ContinuationIndicator { get; init; } 
    /// <summary>
    /// Additional report attributes or information.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Report format.
    /// </summary>
    public OutputFormat5Code? Format { get; init; } 
    /// <summary>
    /// Other report format defined by national organization or by bi-lateral agreement.
    /// </summary>
    public IsoMax35Text? OtherFormat { get; init; } 
    /// <summary>
    /// Contains the content of a report.
    /// </summary>
    public ReportContent1? Content { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
