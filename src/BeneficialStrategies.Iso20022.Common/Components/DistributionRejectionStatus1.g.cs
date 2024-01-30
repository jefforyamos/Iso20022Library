﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DistributionRejectionStatus1.  ISO2002 ID# _RlXZUtp-Ed-ak6NoX_4Aeg_-2041243325.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the rejection status of a global movement.
/// </summary>
public partial record DistributionRejectionStatus1
{
    #nullable enable
    
    /// <summary>
    /// The rejection reason.
    /// </summary>
    public IRejectionReason19FormatChoice? Reason { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
