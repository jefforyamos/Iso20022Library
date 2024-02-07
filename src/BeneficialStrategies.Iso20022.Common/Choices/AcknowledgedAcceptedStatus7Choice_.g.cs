﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AcknowledgedAcceptedStatus7Choice.  ISO2002 ID# _y9mO8f7qEeCvPoRGOxRobQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies whether the status is provided with a reason or not.
/// </summary>
[KnownType(typeof(AcknowledgedAcceptedStatus7Choice.NoSpecifiedReason))]
[KnownType(typeof(AcknowledgedAcceptedStatus7Choice.Reason))]
public abstract partial record AcknowledgedAcceptedStatus7Choice_ : IIsoXmlSerilizable<AcknowledgedAcceptedStatus7Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static AcknowledgedAcceptedStatus7Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => AcknowledgedAcceptedStatus7Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => AcknowledgedAcceptedStatus7Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid AcknowledgedAcceptedStatus7Choice choice.")
        };
    }
}
