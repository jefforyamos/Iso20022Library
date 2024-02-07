﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ModificationProcessingStatus7Choice.  ISO2002 ID# _1bR8UTp4EeWVrPy0StzzSg.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of format for the processing status.
/// </summary>
[KnownType(typeof(ModificationProcessingStatus7Choice.AcknowledgedAccepted))]
[KnownType(typeof(ModificationProcessingStatus7Choice.PendingProcessing))]
[KnownType(typeof(ModificationProcessingStatus7Choice.Denied))]
[KnownType(typeof(ModificationProcessingStatus7Choice.Rejected))]
[KnownType(typeof(ModificationProcessingStatus7Choice.Repaired))]
[KnownType(typeof(ModificationProcessingStatus7Choice.Modified))]
[KnownType(typeof(ModificationProcessingStatus7Choice.Proprietary))]
public abstract partial record ModificationProcessingStatus7Choice_ : IIsoXmlSerilizable<ModificationProcessingStatus7Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ModificationProcessingStatus7Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AckdAccptd" => ModificationProcessingStatus7Choice.AcknowledgedAccepted.Deserialize(elementWithPayload),
             "PdgPrcg" => ModificationProcessingStatus7Choice.PendingProcessing.Deserialize(elementWithPayload),
             "Dnd" => ModificationProcessingStatus7Choice.Denied.Deserialize(elementWithPayload),
             "Rjctd" => ModificationProcessingStatus7Choice.Rejected.Deserialize(elementWithPayload),
             "Rprd" => ModificationProcessingStatus7Choice.Repaired.Deserialize(elementWithPayload),
             "Modfd" => ModificationProcessingStatus7Choice.Modified.Deserialize(elementWithPayload),
             "Prtry" => ModificationProcessingStatus7Choice.Proprietary.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ModificationProcessingStatus7Choice choice.")
        };
    }
}
