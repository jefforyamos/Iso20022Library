﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ConditionallyAcceptedStatusReason1.  ISO2002 ID# _UyQMEdp-Ed-ak6NoX_4Aeg_524981898.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a conditionally accepted status.
/// </summary>
public partial record ConditionallyAcceptedStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for a conditionally accepted status in structured form.
    /// </summary>
    public IReadOnlyCollection<ConditionallyAcceptedStatusReason1Code> Structured { get; init; } = [];
    /// <summary>
    /// Reason for a conditionally accepted status in free format text.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
