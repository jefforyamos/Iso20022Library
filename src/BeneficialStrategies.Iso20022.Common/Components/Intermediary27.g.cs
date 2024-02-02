﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Intermediary27.  ISO2002 ID# _xq_nTQf7EeSNB7vR9dc0nw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
[DataContract]
[XmlType]
public partial record Intermediary27
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [DataMember]
    public required PartyIdentification2Choice_ Identification { get; init; } 
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [DataMember]
    public Account7? Account { get; init; } 
    /// <summary>
    /// Function performed by the intermediary.
    /// </summary>
    [DataMember]
    public Role4Choice_? Role { get; init; } 
    
    #nullable disable
}
