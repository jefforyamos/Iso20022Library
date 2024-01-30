﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RejectionReason23.  ISO2002 ID# _wB6BMQgJEeSFYfyUKDXKaw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason to reject the message.
/// </summary>
public partial record RejectionReason23
{
    #nullable enable
    
    /// <summary>
    /// Reason to reject the message.
    /// </summary>
    public required MessageRejectedReason1Code Reason { get; init; } 
    /// <summary>
    /// Additional information about the rejection reason.
    /// </summary>
    public IsoMax140Text? AdditionalInformation { get; init; } 
    /// <summary>
    /// Identification of the invalid or unrecognised reference.
    /// </summary>
    public ILinkedMessage1Choice? LinkedMessage { get; init; } 
    
    #nullable disable
}
