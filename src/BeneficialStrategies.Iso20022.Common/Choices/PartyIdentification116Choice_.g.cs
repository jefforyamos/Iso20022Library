﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification116Choice.  ISO2002 ID# _GXyTIZEpEeakHoV5BVecAQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification116Choice.AnyBIC))]
[KnownType(typeof(PartyIdentification116Choice.NameAndAddress))]
[KnownType(typeof(PartyIdentification116Choice.Country))]
public abstract partial record PartyIdentification116Choice_ : IIsoXmlSerilizable<PartyIdentification116Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification116Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AnyBIC" => PartyIdentification116Choice.AnyBIC.Deserialize(elementWithPayload),
             "NmAndAdr" => PartyIdentification116Choice.NameAndAddress.Deserialize(elementWithPayload),
             "Ctry" => PartyIdentification116Choice.Country.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification116Choice choice.")
        };
    }
}
