﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification137Choice.  ISO2002 ID# __2ajK_fDEeiNZp_PtLohLw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between different formats for the identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification137Choice.AnyBIC))]
[KnownType(typeof(PartyIdentification137Choice.ProprietaryIdentification))]
[KnownType(typeof(PartyIdentification137Choice.NameAndAddress))]
public abstract partial record PartyIdentification137Choice_ : IIsoXmlSerilizable<PartyIdentification137Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification137Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AnyBIC" => PartyIdentification137Choice.AnyBIC.Deserialize(elementWithPayload),
             "PrtryId" => PartyIdentification137Choice.ProprietaryIdentification.Deserialize(elementWithPayload),
             "NmAndAdr" => PartyIdentification137Choice.NameAndAddress.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification137Choice choice.")
        };
    }
}
