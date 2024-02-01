﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionStandingInstructionCancellationRejectionStatus1.  ISO2002 ID# _Rk6tZNp-Ed-ak6NoX_4Aeg_1198444441.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of a standing instruction cancellation request.
/// </summary>
public partial record CorporateActionStandingInstructionCancellationRejectionStatus1
{
    #nullable enable
    
    /// <summary>
    /// The rejection reason.
    /// </summary>
    public RejectionReason10FormatChoice_[] Reason { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
