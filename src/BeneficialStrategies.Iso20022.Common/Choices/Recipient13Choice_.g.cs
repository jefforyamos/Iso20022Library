﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Recipient13Choice.  ISO2002 ID# _huWK8XDCEe2MCaKO5AtGsA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Identification of a cryptographic asymmetric key.
/// </summary>
[KnownType(typeof(Recipient13Choice.IssuerAndSerialNumber))]
[KnownType(typeof(Recipient13Choice.SubjectKeyIdentifier))]
public abstract partial record Recipient13Choice_ : IIsoXmlSerilizable<Recipient13Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Recipient13Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "IssrAndSrlNb" => Recipient13Choice.IssuerAndSerialNumber.Deserialize(elementWithPayload),
             "SbjtKeyIdr" => Recipient13Choice.SubjectKeyIdentifier.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Recipient13Choice choice.")
        };
    }
}
