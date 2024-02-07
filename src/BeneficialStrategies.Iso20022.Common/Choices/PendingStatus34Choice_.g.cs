﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingStatus34Choice.  ISO2002 ID# _T9xmsVhbEeSewsfsZR0hxA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a reason or no reason for the corporate action instruction processing pending status.
/// </summary>
[KnownType(typeof(PendingStatus34Choice.NoSpecifiedReason))]
[KnownType(typeof(PendingStatus34Choice.Reason))]
public abstract partial record PendingStatus34Choice_ : IIsoXmlSerilizable<PendingStatus34Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PendingStatus34Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => PendingStatus34Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => PendingStatus34Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PendingStatus34Choice choice.")
        };
    }
}
