﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification68Choice.  ISO2002 ID# _AUMj09okEeC60axPepSq7g_-143821104.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification68Choice.BIC))]
[KnownType(typeof(PartyIdentification68Choice.NameAndAddress))]
[KnownType(typeof(PartyIdentification68Choice.Country))]
public abstract partial record PartyIdentification68Choice_ : IIsoXmlSerilizable<PartyIdentification68Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification68Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "BIC" => PartyIdentification68Choice.BIC.Deserialize(elementWithPayload),
             "NmAndAdr" => PartyIdentification68Choice.NameAndAddress.Deserialize(elementWithPayload),
             "Ctry" => PartyIdentification68Choice.Country.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification68Choice choice.")
        };
    }
}
