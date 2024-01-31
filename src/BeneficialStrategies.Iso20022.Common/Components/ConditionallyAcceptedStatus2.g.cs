﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ConditionallyAcceptedStatus2.  ISO2002 ID# _RM7EKdp-Ed-ak6NoX_4Aeg_-367108012.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is accepted under certain conditions.
/// </summary>
public partial record ConditionallyAcceptedStatus2
{
    #nullable enable
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    /// <summary>
    /// Reason for the conditionally accepted status.
    /// </summary>
    public IReadOnlyCollection<ConditionallyAcceptedStatusReason2> ReasonDetails { get; init; } = [];
    
    #nullable disable
}
