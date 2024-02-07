﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification33Choice.  ISO2002 ID# _QPiO19p-Ed-ak6NoX_4Aeg_392714939.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification33Choice.AnyBIC))]
[KnownType(typeof(PartyIdentification33Choice.ProprietaryIdentification))]
[KnownType(typeof(PartyIdentification33Choice.NameAndAddress))]
public abstract partial record PartyIdentification33Choice_ : IIsoXmlSerilizable<PartyIdentification33Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification33Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AnyBIC" => PartyIdentification33Choice.AnyBIC.Deserialize(elementWithPayload),
             "PrtryId" => PartyIdentification33Choice.ProprietaryIdentification.Deserialize(elementWithPayload),
             "NmAndAdr" => PartyIdentification33Choice.NameAndAddress.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification33Choice choice.")
        };
    }
}
