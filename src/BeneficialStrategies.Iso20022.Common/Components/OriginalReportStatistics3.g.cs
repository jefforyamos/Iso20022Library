﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalReportStatistics3.  ISO2002 ID# _4h_4QdHEEeaokquJJ-K6uA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statistical information on the processing of records included in the original report.
/// </summary>
public partial record OriginalReportStatistics3
{
    #nullable enable
    
    /// <summary>
    /// Total numbers of records included in the original file.
    /// </summary>
    public required IsoMax15NumericText TotalNumberOfRecords { get; init; } 
    /// <summary>
    /// Detailed information on the number of records for each records status.
    /// </summary>
    public NumberOfRecordsPerStatus1? NumberOfRecordsPerStatus { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
