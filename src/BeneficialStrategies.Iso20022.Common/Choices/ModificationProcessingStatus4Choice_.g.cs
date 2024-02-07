﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ModificationProcessingStatus4Choice.  ISO2002 ID# _gUOMsVhgEeS8HfHHd4stCA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the processing status.
/// </summary>
[KnownType(typeof(ModificationProcessingStatus4Choice.AcknowledgedAccepted))]
[KnownType(typeof(ModificationProcessingStatus4Choice.PendingProcessing))]
[KnownType(typeof(ModificationProcessingStatus4Choice.Denied))]
[KnownType(typeof(ModificationProcessingStatus4Choice.Rejected))]
[KnownType(typeof(ModificationProcessingStatus4Choice.Repaired))]
[KnownType(typeof(ModificationProcessingStatus4Choice.Modified))]
[KnownType(typeof(ModificationProcessingStatus4Choice.Proprietary))]
public abstract partial record ModificationProcessingStatus4Choice_ : IIsoXmlSerilizable<ModificationProcessingStatus4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ModificationProcessingStatus4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AckdAccptd" => ModificationProcessingStatus4Choice.AcknowledgedAccepted.Deserialize(elementWithPayload),
             "PdgPrcg" => ModificationProcessingStatus4Choice.PendingProcessing.Deserialize(elementWithPayload),
             "Dnd" => ModificationProcessingStatus4Choice.Denied.Deserialize(elementWithPayload),
             "Rjctd" => ModificationProcessingStatus4Choice.Rejected.Deserialize(elementWithPayload),
             "Rprd" => ModificationProcessingStatus4Choice.Repaired.Deserialize(elementWithPayload),
             "Modfd" => ModificationProcessingStatus4Choice.Modified.Deserialize(elementWithPayload),
             "Prtry" => ModificationProcessingStatus4Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ModificationProcessingStatus4Choice choice.")
        };
    }
}
