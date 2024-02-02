﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReservationReport6.  ISO2002 ID# _DgmhZ24-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on the reservation or on a business error.
/// </summary>
[DataContract]
[XmlType]
public partial record ReservationReport6
{
    #nullable enable
    
    /// <summary>
    /// Identification of the reservation on which information is requested.
    /// </summary>
    [DataMember]
    public required ReservationIdentification2 ReservationIdentification { get; init; } 
    /// <summary>
    /// Requested information on the limit.
    /// </summary>
    [DataMember]
    public required ReservationOrError9Choice_ ReservationOrError { get; init; } 
    
    #nullable disable
}
