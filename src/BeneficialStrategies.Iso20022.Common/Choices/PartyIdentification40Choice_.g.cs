﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification40Choice.  ISO2002 ID# _BfsUT_L-Ed-3lpUMQaXLjQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification40Choice.AnyBIC))]
[KnownType(typeof(PartyIdentification40Choice.ProprietaryIdentification))]
[KnownType(typeof(PartyIdentification40Choice.NameAndAddress))]
public abstract partial record PartyIdentification40Choice_ : IIsoXmlSerilizable<PartyIdentification40Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification40Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AnyBIC" => PartyIdentification40Choice.AnyBIC.Deserialize(elementWithPayload),
             "PrtryId" => PartyIdentification40Choice.ProprietaryIdentification.Deserialize(elementWithPayload),
             "NmAndAdr" => PartyIdentification40Choice.NameAndAddress.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification40Choice choice.")
        };
    }
}
