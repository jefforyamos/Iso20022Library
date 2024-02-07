﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingStatus41Choice.  ISO2002 ID# _tDTUwUGSEeWqy4niLuXETA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a reason or no reason for the corporate action event processing pending status.
/// </summary>
[KnownType(typeof(PendingStatus41Choice.NoSpecifiedReason))]
[KnownType(typeof(PendingStatus41Choice.Reason))]
public abstract partial record PendingStatus41Choice_ : IIsoXmlSerilizable<PendingStatus41Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PendingStatus41Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => PendingStatus41Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => PendingStatus41Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PendingStatus41Choice choice.")
        };
    }
}
