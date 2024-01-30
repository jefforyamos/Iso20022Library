﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionInstructionRejectionStatus1.  ISO2002 ID# _Rkw8Ydp-Ed-ak6NoX_4Aeg_-175735359.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of an election advice.
/// </summary>
public partial record CorporateActionInstructionRejectionStatus1
{
    #nullable enable
    
    /// <summary>
    /// The rejection reason.
    /// </summary>
    public IRejectionReason18FormatChoice? Reason { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
