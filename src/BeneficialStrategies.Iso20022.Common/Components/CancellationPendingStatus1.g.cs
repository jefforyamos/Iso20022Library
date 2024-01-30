﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CancellationPendingStatus1.  ISO2002 ID# _RSb2Qtp-Ed-ak6NoX_4Aeg_1032897405.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for the cancellation pending status.
/// </summary>
public partial record CancellationPendingStatus1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the cancellation pending status.
    /// </summary>
    public required IsoMax350Text Reason { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason for the cancellation pending status.
    /// </summary>
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    
    #nullable disable
}
