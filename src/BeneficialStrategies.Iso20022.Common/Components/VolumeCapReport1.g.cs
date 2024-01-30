﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VolumeCapReport1.  ISO2002 ID# _AE700CohEeW8U9pZarPocw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Double volume cap report.
/// </summary>
public partial record VolumeCapReport1
{
    #nullable enable
    
    /// <summary>
    /// Date or date range the report relates to.
    /// </summary>
    public IPeriod4Choice? ReportingPeriod { get; init; } 
    /// <summary>
    /// The venue this report is in relation to specified as {MIC} (segment MIC, where available, otherwise operational MIC).
    /// </summary>
    public IsoMICIdentifier? TradingVenue { get; init; } 
    /// <summary>
    /// Volume cap data specific to a reporting period.
    /// </summary>
    public VolumeCapReport2? InstrumentReport { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
