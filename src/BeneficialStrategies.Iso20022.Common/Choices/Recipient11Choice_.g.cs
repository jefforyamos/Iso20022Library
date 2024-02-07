﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Recipient11Choice.  ISO2002 ID# _6nK84VE0EeyApZmLzm74zA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Transport key or key encryption key (KEK) for the recipient.
/// </summary>
[KnownType(typeof(Recipient11Choice.KeyTransport))]
[KnownType(typeof(Recipient11Choice.KEK))]
[KnownType(typeof(Recipient11Choice.KeyIdentifier))]
public abstract partial record Recipient11Choice_ : IIsoXmlSerilizable<Recipient11Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Recipient11Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "KeyTrnsprt" => Recipient11Choice.KeyTransport.Deserialize(elementWithPayload),
             "KEK" => Recipient11Choice.KEK.Deserialize(elementWithPayload),
             "KeyIdr" => Recipient11Choice.KeyIdentifier.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Recipient11Choice choice.")
        };
    }
}
