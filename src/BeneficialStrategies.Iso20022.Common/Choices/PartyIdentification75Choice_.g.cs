﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification75Choice.  ISO2002 ID# _HUH4SUiQEeOdL6nMHefDgg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification75Choice.AnyBIC))]
[KnownType(typeof(PartyIdentification75Choice.NameAndAddress))]
[KnownType(typeof(PartyIdentification75Choice.Country))]
public abstract partial record PartyIdentification75Choice_ : IIsoXmlSerilizable<PartyIdentification75Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification75Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AnyBIC" => PartyIdentification75Choice.AnyBIC.Deserialize(elementWithPayload),
             "NmAndAdr" => PartyIdentification75Choice.NameAndAddress.Deserialize(elementWithPayload),
             "Ctry" => PartyIdentification75Choice.Country.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification75Choice choice.")
        };
    }
}
