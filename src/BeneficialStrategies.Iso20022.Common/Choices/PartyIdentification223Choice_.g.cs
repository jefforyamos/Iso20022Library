﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification223Choice.  ISO2002 ID# _1G7dE6-EEemJ1NnLPsTFaw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification223Choice.LegalPerson))]
[KnownType(typeof(PartyIdentification223Choice.NaturalPerson))]
public abstract partial record PartyIdentification223Choice_ : IIsoXmlSerilizable<PartyIdentification223Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification223Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "LglPrsn" => PartyIdentification223Choice.LegalPerson.Deserialize(elementWithPayload),
             "NtrlPrsn" => PartyIdentification223Choice.NaturalPerson.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification223Choice choice.")
        };
    }
}
