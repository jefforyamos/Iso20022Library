﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification93Choice.  ISO2002 ID# _bF4nATqmEeWyoP0PbocV1Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification93Choice.AnyBIC))]
[KnownType(typeof(PartyIdentification93Choice.ProprietaryIdentification))]
[KnownType(typeof(PartyIdentification93Choice.NameAndAddress))]
[KnownType(typeof(PartyIdentification93Choice.Country))]
public abstract partial record PartyIdentification93Choice_ : IIsoXmlSerilizable<PartyIdentification93Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification93Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AnyBIC" => PartyIdentification93Choice.AnyBIC.Deserialize(elementWithPayload),
             "PrtryId" => PartyIdentification93Choice.ProprietaryIdentification.Deserialize(elementWithPayload),
             "NmAndAdr" => PartyIdentification93Choice.NameAndAddress.Deserialize(elementWithPayload),
             "Ctry" => PartyIdentification93Choice.Country.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification93Choice choice.")
        };
    }
}
