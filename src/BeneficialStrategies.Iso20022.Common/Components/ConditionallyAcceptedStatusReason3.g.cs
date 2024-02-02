﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ConditionallyAcceptedStatusReason3.  ISO2002 ID# _2I_zAEHZEeamVPoS58KxXA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a conditionally accepted status.
/// </summary>
[DataContract]
[XmlType]
public partial record ConditionallyAcceptedStatusReason3
{
    #nullable enable
    
    /// <summary>
    /// Reason for the conditionally accepted status expressed as a code.
    /// </summary>
    [DataMember]
    public required ConditionallyAcceptedStatusReason3Choice_ Reason { get; init; } 
    /// <summary>
    /// Additional information about the conditionally accepted reason.
    /// </summary>
    [DataMember]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
