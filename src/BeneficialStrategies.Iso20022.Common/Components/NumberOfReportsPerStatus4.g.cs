﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NumberOfReportsPerStatus4.  ISO2002 ID# _6MfxgXA0EeuQQPLl0vKpYw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Number of reports per status.
/// </summary>
public partial record NumberOfReportsPerStatus4
{
    #nullable enable
    
    /// <summary>
    /// Number of individual reports sent / received, detailed per status.
    /// </summary>
    public required IsoMax15NumericText DetailedNumberOfReports { get; init; } 
    /// <summary>
    /// Common report status for all individual reports sent / received.
    /// </summary>
    public required PairedReconciled3Code DetailedStatus { get; init; } 
    
    #nullable disable
}
