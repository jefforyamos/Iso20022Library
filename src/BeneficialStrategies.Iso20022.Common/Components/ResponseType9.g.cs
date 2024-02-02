﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ResponseType9.  ISO2002 ID# _mqZT0dxWEeioifFt1dhnJA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response of a requested service.
/// </summary>
[DataContract]
[XmlType]
public partial record ResponseType9
{
    #nullable enable
    
    /// <summary>
    /// Result of the requested transaction.
    /// </summary>
    [DataMember]
    public required Response5Code Response { get; init; } 
    /// <summary>
    /// Detail of the response.
    /// </summary>
    [DataMember]
    public RetailerResultDetail1Code? ResponseReason { get; init; } 
    /// <summary>
    /// Additional information to be logged for further examination.
    /// </summary>
    [DataMember]
    public IsoMax140Text? AdditionalResponseInformation { get; init; } 
    
    #nullable disable
}
