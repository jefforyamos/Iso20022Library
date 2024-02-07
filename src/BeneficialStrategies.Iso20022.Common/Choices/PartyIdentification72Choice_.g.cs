﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyIdentification72Choice.  ISO2002 ID# _3JsB7nHeEeG8t-w1mFnmhg_-1626691800.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of identification of a party. The party can be identified by giving a BIC or a proprietary code.
/// </summary>
[KnownType(typeof(PartyIdentification72Choice.AnyBIC))]
[KnownType(typeof(PartyIdentification72Choice.ProprietaryIdentification))]
public abstract partial record PartyIdentification72Choice_ : IIsoXmlSerilizable<PartyIdentification72Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PartyIdentification72Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AnyBIC" => PartyIdentification72Choice.AnyBIC.Deserialize(elementWithPayload),
             "PrtryId" => PartyIdentification72Choice.ProprietaryIdentification.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PartyIdentification72Choice choice.")
        };
    }
}
