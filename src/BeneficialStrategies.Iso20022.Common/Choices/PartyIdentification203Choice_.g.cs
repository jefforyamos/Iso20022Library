﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification203Choice.  ISO2002 ID# _N8PiUFSXEempisJfoIfvvQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification203Choice.ProprietaryIdentification))]
[KnownType(typeof(PartyIdentification203Choice.LEI))]
public abstract partial record PartyIdentification203Choice_ : IIsoXmlSerilizable<PartyIdentification203Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification203Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "PrtryId" => PartyIdentification203Choice.ProprietaryIdentification.Deserialize(elementWithPayload),
             "LEI" => PartyIdentification203Choice.LEI.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification203Choice choice.")
        };
    }
}
