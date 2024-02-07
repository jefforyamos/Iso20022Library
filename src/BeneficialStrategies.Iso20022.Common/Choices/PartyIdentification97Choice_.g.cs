﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification97Choice.  ISO2002 ID# _P50eUSVJEeWI0orciOKunQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification97Choice.AnyBIC))]
[KnownType(typeof(PartyIdentification97Choice.LegalEntityIdentifier))]
[KnownType(typeof(PartyIdentification97Choice.NameAndAddress))]
[KnownType(typeof(PartyIdentification97Choice.ProprietaryIdentification))]
public abstract partial record PartyIdentification97Choice_ : IIsoXmlSerilizable<PartyIdentification97Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification97Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AnyBIC" => PartyIdentification97Choice.AnyBIC.Deserialize(elementWithPayload),
             "LglNttyIdr" => PartyIdentification97Choice.LegalEntityIdentifier.Deserialize(elementWithPayload),
             "NmAndAdr" => PartyIdentification97Choice.NameAndAddress.Deserialize(elementWithPayload),
             "PrtryId" => PartyIdentification97Choice.ProprietaryIdentification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification97Choice choice.")
        };
    }
}
