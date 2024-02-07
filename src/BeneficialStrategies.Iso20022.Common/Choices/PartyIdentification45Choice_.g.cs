﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification45Choice.  ISO2002 ID# _idS_seaOEd-q8fx_Zl_34A.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification45Choice.AnyBIC))]
[KnownType(typeof(PartyIdentification45Choice.ProprietaryIdentification))]
[KnownType(typeof(PartyIdentification45Choice.NameAndAddress))]
public abstract partial record PartyIdentification45Choice_ : IIsoXmlSerilizable<PartyIdentification45Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification45Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AnyBIC" => PartyIdentification45Choice.AnyBIC.Deserialize(elementWithPayload),
             "PrtryId" => PartyIdentification45Choice.ProprietaryIdentification.Deserialize(elementWithPayload),
             "NmAndAdr" => PartyIdentification45Choice.NameAndAddress.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification45Choice choice.")
        };
    }
}
