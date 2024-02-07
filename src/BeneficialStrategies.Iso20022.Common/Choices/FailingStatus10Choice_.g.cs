﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FailingStatus10Choice.  ISO2002 ID# _3CuZQTqOEeWyoP0PbocV1Q.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of failing status.
/// </summary>
[KnownType(typeof(FailingStatus10Choice.NoSpecifiedReason))]
[KnownType(typeof(FailingStatus10Choice.Reason))]
public abstract partial record FailingStatus10Choice_ : IIsoXmlSerilizable<FailingStatus10Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static FailingStatus10Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => FailingStatus10Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => FailingStatus10Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid FailingStatus10Choice choice.")
        };
    }
}
