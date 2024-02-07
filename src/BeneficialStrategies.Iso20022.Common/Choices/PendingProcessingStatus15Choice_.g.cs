﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingProcessingStatus15Choice.  ISO2002 ID# _6P-zDZNLEeWGlc8L7oPDIg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies whether the status is provided with a reason or not.
/// </summary>
[KnownType(typeof(PendingProcessingStatus15Choice.NoSpecifiedReason))]
[KnownType(typeof(PendingProcessingStatus15Choice.Reason))]
public abstract partial record PendingProcessingStatus15Choice_ : IIsoXmlSerilizable<PendingProcessingStatus15Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static PendingProcessingStatus15Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "NoSpcfdRsn" => PendingProcessingStatus15Choice.NoSpecifiedReason.Deserialize(elementWithPayload),
             "Rsn" => PendingProcessingStatus15Choice.Reason.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid PendingProcessingStatus15Choice choice.")
        };
    }
}
