﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification43Choice.  ISO2002 ID# _eadcW-aOEd-q8fx_Zl_34A.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification43Choice.AnyBIC))]
[KnownType(typeof(PartyIdentification43Choice.ProprietaryIdentification))]
[KnownType(typeof(PartyIdentification43Choice.NameAndAddress))]
public abstract partial record PartyIdentification43Choice_ : IIsoXmlSerilizable<PartyIdentification43Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification43Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AnyBIC" => PartyIdentification43Choice.AnyBIC.Deserialize(elementWithPayload),
             "PrtryId" => PartyIdentification43Choice.ProprietaryIdentification.Deserialize(elementWithPayload),
             "NmAndAdr" => PartyIdentification43Choice.NameAndAddress.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification43Choice choice.")
        };
    }
}
