﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification259.  ISO2002 ID# _nNGsIcWjEeuhguwJmlgagQ.
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
public partial record PartyIdentification259
{
    #nullable enable
    
    /// <summary>
    /// Name of the customer.
    /// </summary>
    [DataMember]
    public IsoMax70Text? Name { get; init; } 
    /// <summary>
    /// Identification of the customer.
    /// </summary>
    [DataMember]
    public PartyIdentification258? Identification { get; init; } 
    /// <summary>
    /// Address of the customer.
    /// </summary>
    [DataMember]
    public Address2? Address { get; init; } 
    /// <summary>
    /// Contact information related to the customer.
    /// </summary>
    [DataMember]
    public Contact3? Contact { get; init; } 
    /// <summary>
    /// Identification of the customer recognized by the taxation authority.
    /// </summary>
    [DataMember]
    public IsoMax70Text? TaxRegistrationIdentification { get; init; } 
    /// <summary>
    /// Additional information about the seller. 
    /// </summary>
    [DataMember]
    public IsoMax1000Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
