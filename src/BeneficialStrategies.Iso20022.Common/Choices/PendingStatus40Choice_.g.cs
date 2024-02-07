﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingStatus40Choice.  ISO2002 ID# _pnOLkTw9EeW3QqUkIQtIUA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies whether the status is provided with a reason or not.
/// </summary>
[KnownType(typeof(PendingStatus40Choice.NoSpecifiedReason))]
[KnownType(typeof(PendingStatus40Choice.Reason))]
public abstract partial record PendingStatus40Choice_ : IIsoXmlSerilizable<PendingStatus40Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PendingStatus40Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => PendingStatus40Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => PendingStatus40Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PendingStatus40Choice choice.")
        };
    }
}
