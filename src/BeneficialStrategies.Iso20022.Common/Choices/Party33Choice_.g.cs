﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Party33Choice.  ISO2002 ID# _5dylEUzQEea8fovz_9xSTQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for the specification of the party.
/// </summary>
[KnownType(typeof(Party33Choice.Organisation))]
[KnownType(typeof(Party33Choice.IndividualPerson))]
public abstract partial record Party33Choice_ : IIsoXmlSerilizable<Party33Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Party33Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Org" => Party33Choice.Organisation.Deserialize(elementWithPayload),
             "IndvPrsn" => Party33Choice.IndividualPerson.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Party33Choice choice.")
        };
    }
}
