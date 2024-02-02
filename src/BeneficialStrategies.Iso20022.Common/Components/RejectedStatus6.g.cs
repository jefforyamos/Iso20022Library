﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RejectedStatus6.  ISO2002 ID# _RLlnZtp-Ed-ak6NoX_4Aeg_-1014963759.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is rejected.
/// </summary>
[DataContract]
[XmlType]
public partial record RejectedStatus6
{
    #nullable enable
    
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [DataMember]
    public required RejectedStatusReason7Code Reason { get; init; } 
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [DataMember]
    public required IsoExtended350Code ExtendedReason { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason for the rejected status.
    /// </summary>
    [DataMember]
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    /// <summary>
    /// Additional information about the rejected status reason.
    /// </summary>
    [DataMember]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
