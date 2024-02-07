﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Recipient10Choice.  ISO2002 ID# _Wl_KAS8jEeu125Ip9zFcsQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Transport key or key encryption key (KEK) for the recipient.
/// </summary>
[KnownType(typeof(Recipient10Choice.KeyTransport))]
[KnownType(typeof(Recipient10Choice.KEK))]
[KnownType(typeof(Recipient10Choice.KeyIdentifier))]
public abstract partial record Recipient10Choice_ : IIsoXmlSerilizable<Recipient10Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static Recipient10Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "KeyTrnsprt" => Recipient10Choice.KeyTransport.Deserialize(elementWithPayload),
             "KEK" => Recipient10Choice.KEK.Deserialize(elementWithPayload),
             "KeyIdr" => Recipient10Choice.KeyIdentifier.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid Recipient10Choice choice.")
        };
    }
}
