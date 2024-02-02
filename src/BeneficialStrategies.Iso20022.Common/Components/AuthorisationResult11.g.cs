﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AuthorisationResult11.  ISO2002 ID# _r1QJ8Y09EeWPUZwhUA4U-w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the authorisation.
/// </summary>
[DataContract]
[XmlType]
public partial record AuthorisationResult11
{
    #nullable enable
    
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [DataMember]
    public GenericIdentification90? AuthorisationEntity { get; init; } 
    /// <summary>
    /// Response to an authorisation request.
    /// </summary>
    [DataMember]
    public required ResponseType5 ResponseToAuthorisation { get; init; } 
    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [DataMember]
    public IsoMin6Max8Text? AuthorisationCode { get; init; } 
    
    #nullable disable
}
