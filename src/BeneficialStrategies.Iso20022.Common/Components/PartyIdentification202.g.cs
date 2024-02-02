﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification202.  ISO2002 ID# _Zfz85D6CEemPvNTzinB5Vw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[DataContract]
[XmlType]
public partial record PartyIdentification202
{
    #nullable enable
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [DataMember]
    public required PersonName1 NameAndAddress { get; init; } 
    /// <summary>
    /// CONCAT
    /// </summary>
    [DataMember]
    public required NaturalPersonIdentification1 Identification { get; init; } 
    
    #nullable disable
}
