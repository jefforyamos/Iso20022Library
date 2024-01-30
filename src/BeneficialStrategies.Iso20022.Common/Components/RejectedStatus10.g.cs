﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RejectedStatus10.  ISO2002 ID# _GI7cUUguEeazC43Xuh-e6w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a rejected status.
/// </summary>
public partial record RejectedStatus10
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    public IRejectedReason21Choice? Reason { get; init; } 
    /// <summary>
    /// Additional information about the rejected reason.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
