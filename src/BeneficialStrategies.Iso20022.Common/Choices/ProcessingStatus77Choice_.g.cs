﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus77Choice.  ISO2002 ID# _AYE5i_fZEeiNZp_PtLohLw.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Choice of formats for a processing status.
/// </summary>
[KnownType(typeof(ProcessingStatus77Choice.AcknowledgedAccepted))]
[KnownType(typeof(ProcessingStatus77Choice.PendingProcessing))]
[KnownType(typeof(ProcessingStatus77Choice.Rejected))]
[KnownType(typeof(ProcessingStatus77Choice.Repair))]
[KnownType(typeof(ProcessingStatus77Choice.Cancelled))]
[KnownType(typeof(ProcessingStatus77Choice.PendingCancellation))]
[KnownType(typeof(ProcessingStatus77Choice.Proprietary))]
[KnownType(typeof(ProcessingStatus77Choice.CancellationRequested))]
[KnownType(typeof(ProcessingStatus77Choice.ModificationRequested))]
public abstract partial record ProcessingStatus77Choice_ : IIsoXmlSerilizable<ProcessingStatus77Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static ProcessingStatus77Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "AckdAccptd" => ProcessingStatus77Choice.AcknowledgedAccepted.Deserialize(elementWithPayload),
             "PdgPrcg" => ProcessingStatus77Choice.PendingProcessing.Deserialize(elementWithPayload),
             "Rjctd" => ProcessingStatus77Choice.Rejected.Deserialize(elementWithPayload),
             "Rpr" => ProcessingStatus77Choice.Repair.Deserialize(elementWithPayload),
             "Canc" => ProcessingStatus77Choice.Cancelled.Deserialize(elementWithPayload),
             "PdgCxl" => ProcessingStatus77Choice.PendingCancellation.Deserialize(elementWithPayload),
             "Prtry" => ProcessingStatus77Choice.Proprietary.Deserialize(elementWithPayload),
             "CxlReqd" => ProcessingStatus77Choice.CancellationRequested.Deserialize(elementWithPayload),
             "ModReqd" => ProcessingStatus77Choice.ModificationRequested.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid ProcessingStatus77Choice choice.")
        };
    }
}
