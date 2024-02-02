﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MessageItemCondition1.  ISO2002 ID# _K86DNH1DEeCF8NjrBemJWQ_-909229730.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Presence condition of a message item.
/// </summary>
[DataContract]
[XmlType]
public partial record MessageItemCondition1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the message and the message item.
    /// </summary>
    [DataMember]
    public required IsoMax140Text ItemIdentification { get; init; } 
    /// <summary>
    /// Condition of presence of the message item.
    /// </summary>
    [DataMember]
    public required MessageItemCondition1Code Condition { get; init; } 
    /// <summary>
    /// Value to be used for the message item.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax140Text> Value { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
