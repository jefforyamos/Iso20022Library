﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingStatus65Choice.  ISO2002 ID# _9FBM3R9QEeuFz_FaCzCLgQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice between a reason or no reason for the corporate action instruction processing pending status.
/// </summary>
[KnownType(typeof(PendingStatus65Choice.NoSpecifiedReason))]
[KnownType(typeof(PendingStatus65Choice.Reason))]
public abstract partial record PendingStatus65Choice_ : IIsoXmlSerilizable<PendingStatus65Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PendingStatus65Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => PendingStatus65Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => PendingStatus65Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PendingStatus65Choice choice.")
        };
    }
}
