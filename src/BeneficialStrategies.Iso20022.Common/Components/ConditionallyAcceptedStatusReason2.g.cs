﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ConditionallyAcceptedStatusReason2.  ISO2002 ID# _RTLdJNp-Ed-ak6NoX_4Aeg_-536648388.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the reason for the conditionally accepted status.
/// </summary>
public partial record ConditionallyAcceptedStatusReason2
{
    #nullable enable
    
    /// <summary>
    /// Reason for the conditionally accepted status.
    /// </summary>
    public required ConditionallyAcceptedStatusReason2Code Reason { get; init; } 
    /// <summary>
    /// Reason for the conditionally accepted status.
    /// </summary>
    public required IsoExtended350Code ExtendedReason { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason for the conditionally accepted status.
    /// </summary>
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    /// <summary>
    /// Additional information about the conditionally accepted status reason.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
