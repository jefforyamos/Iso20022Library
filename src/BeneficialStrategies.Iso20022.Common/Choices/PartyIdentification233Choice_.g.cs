﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification233Choice.  ISO2002 ID# _6264AfQ0EeqAradXpAelDQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification233Choice.LegalPerson))]
[KnownType(typeof(PartyIdentification233Choice.NaturalPerson))]
public abstract partial record PartyIdentification233Choice_ : IIsoXmlSerilizable<PartyIdentification233Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification233Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "LglPrsn" => PartyIdentification233Choice.LegalPerson.Deserialize(elementWithPayload),
             "NtrlPrsn" => PartyIdentification233Choice.NaturalPerson.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification233Choice choice.")
        };
    }
}
