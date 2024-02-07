﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Party24Choice.  ISO2002 ID# _Zivv0WW8EeSHcOWXSsMhqw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the specification of the party.
/// </summary>
[KnownType(typeof(Party24Choice.Organisation))]
[KnownType(typeof(Party24Choice.IndividualPerson))]
public abstract partial record Party24Choice_ : IIsoXmlSerilizable<Party24Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Party24Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Org" => Party24Choice.Organisation.Deserialize(elementWithPayload),
             "IndvPrsn" => Party24Choice.IndividualPerson.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Party24Choice choice.")
        };
    }
}
