﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PendingStatusReason11.  ISO2002 ID# _cel4NZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies reasons for the pending status.
/// </summary>
public partial record PendingStatusReason11
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction's processing is pending.
    /// </summary>
    public required IPendingReason34Choice ReasonCode { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
