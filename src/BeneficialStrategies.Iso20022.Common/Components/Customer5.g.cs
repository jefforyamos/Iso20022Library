﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Customer5.  ISO2002 ID# _Uany0vPmEeihCvvpsmGI2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the customer
/// </summary>
[DataContract]
[XmlType]
public partial record Customer5
{
    #nullable enable
    
    /// <summary>
    /// Name of the customer.
    /// </summary>
    [DataMember]
    public IsoMax70Text? Name { get; init; } 
    /// <summary>
    /// Details of the party identification.
    /// </summary>
    [DataMember]
    public required PartyIdentification208 Identification { get; init; } 
    /// <summary>
    /// Number or code assigned by an airline, company or other party to track or uniquely identify a person, department or project.
    /// </summary>
    [DataMember]
    public IsoMax70Text? CustomerFileReferenceNumber { get; init; } 
    /// <summary>
    /// Age of the customer.
    /// </summary>
    [DataMember]
    public IsoMax2NumericText? Age { get; init; } 
    /// <summary>
    /// Address details of the customer.
    /// </summary>
    [DataMember]
    public Address1? Address { get; init; } 
    /// <summary>
    /// Contact information related to the customer.
    /// </summary>
    [DataMember]
    public Contact6? Contact { get; init; } 
    
    #nullable disable
}
