﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ModificationProcessingStatus8Choice.  ISO2002 ID# _6QCdM5NLEeWGlc8L7oPDIg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the processing status.
/// </summary>
[KnownType(typeof(ModificationProcessingStatus8Choice.AcknowledgedAccepted))]
[KnownType(typeof(ModificationProcessingStatus8Choice.PendingProcessing))]
[KnownType(typeof(ModificationProcessingStatus8Choice.Denied))]
[KnownType(typeof(ModificationProcessingStatus8Choice.Rejected))]
[KnownType(typeof(ModificationProcessingStatus8Choice.Repaired))]
[KnownType(typeof(ModificationProcessingStatus8Choice.Modified))]
[KnownType(typeof(ModificationProcessingStatus8Choice.Proprietary))]
public abstract partial record ModificationProcessingStatus8Choice_ : IIsoXmlSerilizable<ModificationProcessingStatus8Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ModificationProcessingStatus8Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AckdAccptd" => ModificationProcessingStatus8Choice.AcknowledgedAccepted.Deserialize(elementWithPayload),
             "PdgPrcg" => ModificationProcessingStatus8Choice.PendingProcessing.Deserialize(elementWithPayload),
             "Dnd" => ModificationProcessingStatus8Choice.Denied.Deserialize(elementWithPayload),
             "Rjctd" => ModificationProcessingStatus8Choice.Rejected.Deserialize(elementWithPayload),
             "Rprd" => ModificationProcessingStatus8Choice.Repaired.Deserialize(elementWithPayload),
             "Modfd" => ModificationProcessingStatus8Choice.Modified.Deserialize(elementWithPayload),
             "Prtry" => ModificationProcessingStatus8Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ModificationProcessingStatus8Choice choice.")
        };
    }
}
