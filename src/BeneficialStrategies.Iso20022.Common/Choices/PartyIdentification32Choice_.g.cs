﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification32Choice.  ISO2002 ID# _AUVtwdokEeC60axPepSq7g_2140402987.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of identification of a party.
/// </summary>
[KnownType(typeof(PartyIdentification32Choice.BIC))]
[KnownType(typeof(PartyIdentification32Choice.ProprietaryIdentification))]
[KnownType(typeof(PartyIdentification32Choice.NameAndAddress))]
public abstract partial record PartyIdentification32Choice_ : IIsoXmlSerilizable<PartyIdentification32Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification32Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "BIC" => PartyIdentification32Choice.BIC.Deserialize(elementWithPayload),
             "PrtryId" => PartyIdentification32Choice.ProprietaryIdentification.Deserialize(elementWithPayload),
             "NmAndAdr" => PartyIdentification32Choice.NameAndAddress.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification32Choice choice.")
        };
    }
}
