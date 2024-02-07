﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification240Choice.  ISO2002 ID# _mF6ywStKEeyOa655cLd-DQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification240Choice.BIC))]
[KnownType(typeof(PartyIdentification240Choice.ProprietaryIdentification))]
[KnownType(typeof(PartyIdentification240Choice.NameAndAddress))]
public abstract partial record PartyIdentification240Choice_ : IIsoXmlSerilizable<PartyIdentification240Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification240Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "BIC" => PartyIdentification240Choice.BIC.Deserialize(elementWithPayload),
             "PrtryId" => PartyIdentification240Choice.ProprietaryIdentification.Deserialize(elementWithPayload),
             "NmAndAdr" => PartyIdentification240Choice.NameAndAddress.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification240Choice choice.")
        };
    }
}
