﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RejectionOrRepairReason42.  ISO2002 ID# _ds1eBTi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for the rejection or repair status.
/// </summary>
public partial record RejectionOrRepairReason42
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejected or repair status.
    /// </summary>
    public required IRejectionAndRepairReason42Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    
    #nullable disable
}
