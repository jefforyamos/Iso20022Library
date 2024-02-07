﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Recipient2Choice.  ISO2002 ID# _EvioMQioEeKn9O5oyej_zw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Transport key or key encryption key (KEK) for the recipient.
/// </summary>
[KnownType(typeof(Recipient2Choice.KeyTransport))]
[KnownType(typeof(Recipient2Choice.KEK))]
public abstract partial record Recipient2Choice_ : IIsoXmlSerilizable<Recipient2Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Recipient2Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "KeyTrnsprt" => Recipient2Choice.KeyTransport.Deserialize(elementWithPayload),
             "KEK" => Recipient2Choice.KEK.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Recipient2Choice choice.")
        };
    }
}
