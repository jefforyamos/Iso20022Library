﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification240.  ISO2002 ID# _7KtWtfQ0EeqAradXpAelDQ.
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
public partial record PartyIdentification240
{
    #nullable enable
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [DataMember]
    public required PersonName3 NameAndAddress { get; init; } 
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [DataMember]
    public IsoMax256Text? EmailAddress { get; init; } 
    /// <summary>
    /// Natural person local identification and type.
    /// </summary>
    [DataMember]
    public NaturalPersonIdentification1? Identification { get; init; } 
    /// <summary>
    /// Nationality of the person.
    /// </summary>
    [DataMember]
    public CountryCode? Nationality { get; init; } 
    /// <summary>
    /// Date on which and place at which a born person is born.
    /// </summary>
    [DataMember]
    public DateAndPlaceOfBirth2? DateAndPlaceOfBirth { get; init; } 
    
    #nullable disable
}
