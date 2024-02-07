﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Party31Choice.  ISO2002 ID# _HQ4TwSCBEeWhHbfCMWc1cw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the specification of the party.
/// </summary>
[KnownType(typeof(Party31Choice.Organisation))]
[KnownType(typeof(Party31Choice.IndividualPerson))]
public abstract partial record Party31Choice_ : IIsoXmlSerilizable<Party31Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Party31Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Org" => Party31Choice.Organisation.Deserialize(elementWithPayload),
             "IndvPrsn" => Party31Choice.IndividualPerson.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Party31Choice choice.")
        };
    }
}
