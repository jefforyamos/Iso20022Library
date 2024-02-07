﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingStatus45Choice.  ISO2002 ID# _5SGOYZNLEeWGlc8L7oPDIg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies whether the status is provided with a reason or not.
/// </summary>
[KnownType(typeof(PendingStatus45Choice.NoSpecifiedReason))]
[KnownType(typeof(PendingStatus45Choice.Reason))]
public abstract partial record PendingStatus45Choice_ : IIsoXmlSerilizable<PendingStatus45Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PendingStatus45Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => PendingStatus45Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => PendingStatus45Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PendingStatus45Choice choice.")
        };
    }
}
