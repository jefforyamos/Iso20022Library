﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification42Choice.  ISO2002 ID# _v1Alz_L-Ed-3lpUMQaXLjQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification42Choice.BICFI))]
[KnownType(typeof(PartyIdentification42Choice.NameAndAddress))]
[KnownType(typeof(PartyIdentification42Choice.ProprietaryIdentification))]
public abstract partial record PartyIdentification42Choice_ : IIsoXmlSerilizable<PartyIdentification42Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification42Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "BICFI" => PartyIdentification42Choice.BICFI.Deserialize(elementWithPayload),
             "NmAndAdr" => PartyIdentification42Choice.NameAndAddress.Deserialize(elementWithPayload),
             "PrtryId" => PartyIdentification42Choice.ProprietaryIdentification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification42Choice choice.")
        };
    }
}
