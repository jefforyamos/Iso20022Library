﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContactAttributes6.  ISO2002 ID# _bqpfQboKEeq5Lv5RTGDs7Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication device number or address used for communication.
/// </summary>
[DataContract]
[XmlType]
public partial record ContactAttributes6
{
    #nullable enable
    
    /// <summary>
    /// Name of the party.
    /// </summary>
    [DataMember]
    public IsoMax350Text? Name { get; init; } 
    /// <summary>
    /// Address of the party.
    /// </summary>
    [DataMember]
    public PostalAddress1? PostalAddress { get; init; } 
    /// <summary>
    /// Phone number of the party.
    /// </summary>
    [DataMember]
    public IsoPhoneNumber? PhoneNumber { get; init; } 
    /// <summary>
    /// Fax number of the party.
    /// </summary>
    [DataMember]
    public IsoPhoneNumber? FaxNumber { get; init; } 
    /// <summary>
    /// Address for electronic mail (e-mail) for the party.
    /// </summary>
    [DataMember]
    public IsoMax256Text? EmailAddress { get; init; } 
    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [DataMember]
    public IsoMax2048Text? URLAddress { get; init; } 
    /// <summary>
    /// Identification of the party expressed as a BIC.
    /// </summary>
    [DataMember]
    public IsoAnyBICDec2014Identifier? AnyBIC { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    [DataMember]
    public IsoLEIIdentifier? LEI { get; init; } 
    
    #nullable disable
}
