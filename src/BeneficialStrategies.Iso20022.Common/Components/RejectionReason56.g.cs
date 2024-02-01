﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RejectionReason56.  ISO2002 ID# _WY1VU-ijEeuLe8v4JEtDDg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a rejected status.
/// </summary>
public partial record RejectionReason56
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    public required RejectedReason45Choice_ Reason { get; init; } 
    /// <summary>
    /// Additional information about the rejected status reason.
    /// </summary>
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
