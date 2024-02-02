﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentIdentification24.  ISO2002 ID# _QBS1o_5REeCtrO5qCU90cA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the message number and the query identification.
/// </summary>
[DataContract]
[XmlType]
public partial record DocumentIdentification24
{
    #nullable enable
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [DataMember]
    public DocumentNumber1Choice_? MessageNumber { get; init; } 
    /// <summary>
    /// Reference to the query identification.
    /// </summary>
    [DataMember]
    public required Identification1 Reference { get; init; } 
    
    #nullable disable
}
