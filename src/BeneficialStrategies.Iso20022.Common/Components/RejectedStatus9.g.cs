﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RejectedStatus9.  ISO2002 ID# _IS4acUHjEea8I67lh6qdSQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a rejected status.
/// </summary>
public partial record RejectedStatus9
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    public IRejectedReason20Choice? Reason { get; init; } 
    /// <summary>
    /// Additional information about the rejected reason.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
