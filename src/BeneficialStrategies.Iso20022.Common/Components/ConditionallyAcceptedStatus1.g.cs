﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ConditionallyAcceptedStatus1.  ISO2002 ID# _UyQMGtp-Ed-ak6NoX_4Aeg_94624297.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status that is accepted under certain conditions.
/// </summary>
public partial record ConditionallyAcceptedStatus1
{
    #nullable enable
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoReason { get; init; } 
    /// <summary>
    /// Reason for a conditionally accepted status in the report.
    /// </summary>
    public required ConditionallyAcceptedStatusReason1 Reason { get; init; } 
    /// <summary>
    /// Proprietary identification of a reason for a conditionally accepted status in the report.
    /// </summary>
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    
    #nullable disable
}
